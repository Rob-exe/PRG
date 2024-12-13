using System;

class BattleshipGame
{
    static void Main(string[] args)
    {
        char[,] playerBoard = new char[10, 10];
        char[,] computerBoard = new char[10, 10];
        char[,] playerGuessBoard = new char[10, 10];
        char[,] computerGuessBoard = new char[10, 10];
        //Boards created, now to initialize them with worter
        bool wantsToEnd = false;
        while (!wantsToEnd) //loop
        {
        InitializeBoard(playerBoard);
        InitializeBoard(computerBoard);
        InitializeBoard(playerGuessBoard);
        InitializeBoard(computerGuessBoard);
        //Place Ships now, player gets a prompt, then their ships are generated and maybe they'll get a board if they're good
        PlaceShips(playerBoard, "Player");
        PlaceShips(computerBoard, "Computer");

        
            while (true){
                DisplayBoard(playerGuessBoard, "Player Guessing Board");
                PlayerTurn(computerBoard, playerGuessBoard);
                if (CheckWin(playerGuessBoard))
                {
                    Console.WriteLine("Player wins!");
                    break;
                }

                ComputerTurn(playerBoard, computerGuessBoard);
                if (CheckWin(computerGuessBoard))
                {
                    Console.WriteLine("Computer wins!");
                    break;
                }
            }
            Console.WriteLine("Do you want to continue? (y)es/(N)o"); //Asks whether or not usr wants to continue
            char endCase = (char)Console.ReadKey().Key; //Reads key and sets value of wantsToEnd to false
            wantsToEnd = true;
		if (endCase == 89)
		{ //Y is pressed
		    wantsToEnd = false; //continues game
		}
        }
        
    }

    static void InitializeBoard(char[,] board)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                board[i, j] = '~';
            }
        }
    }

    static void DisplayBoard(char[,] board, string boardName)
    {
        Console.WriteLine(boardName);
        Console.WriteLine("  [A] [B] [C] [D] [E] [F] [G] [H] [I] [J]");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("[" + i + "] ");
            for (int j = 0; j < 10; j++)
            {
                switch (board[i, j])
                {
                    case '~':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 'X':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 'O':
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 'S':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.Write("[" + board[i, j] + "] ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static void PlaceShips(char[,] board, string player)
    {
        int[] shipSizes = { 5, 4, 3, 3, 2 };
        foreach (int size in shipSizes)
        {
            bool placed = false;
            while (!placed)
            {
                int x, y;
                char direction;
                if (player == "Player")
                {
                    Console.WriteLine($"Place your ship of size {size}");
                    Console.Write("Enter row (0-9): ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Enter column (A-J): ");
                    y = Console.ReadLine()[0] - 'A';
                    Console.Write("Enter direction (R for right, L for left, U for up, D for down): ");
                    direction = char.ToUpper(Console.ReadLine()[0]);
                }
                else
                {
                    Random rand = new Random();
                    x = rand.Next(10);
                    y = rand.Next(10);
                    direction = rand.Next(4) switch
                    {
                        0 => 'R',
                        1 => 'L',
                        2 => 'U',
                        _ => 'D',
                    };
                }

                if (CanPlaceShip(board, x, y, size, direction))
                {
                    PlaceShip(board, x, y, size, direction);
                    placed = true;
                }
                else
                {
                    if (player == "Player")
                    {
                        Console.WriteLine("Cannot place ship there. Try again.");
                    }
                }
            }
        }
    }

    static bool CanPlaceShip(char[,] board, int x, int y, int size, char direction)
    {
        switch (direction)
        {
            case 'R':
                if (y + size > 10) return false;
                for (int i = 0; i < size; i++)
                {
                    if (board[x, y + i] != '~') return false;
                }
                break;
            case 'L':
                if (y - size + 1 < 0) return false;
                for (int i = 0; i < size; i++)
                {
                    if (board[x, y - i] != '~') return false;
                }
                break;
            case 'U':
                if (x - size + 1 < 0) return false;
                for (int i = 0; i < size; i++)
                {
                    if (board[x - i, y] != '~') return false;
                }
                break;
            case 'D':
                if (x + size > 10) return false;
                for (int i = 0; i < size; i++)
                {
                    if (board[x + i, y] != '~') return false;
                }
                break;
            default:
                return false;
        }

        return true;
    }

    static void PlaceShip(char[,] board, int x, int y, int size, char direction)
    {
        switch (direction)
        {
            case 'R':
                for (int i = 0; i < size; i++)
                {
                    board[x, y + i] = 'S';
                }
                break;
            case 'L':
                for (int i = 0; i < size; i++)
                {
                    board[x, y - i] = 'S';
                }
                break;
            case 'U':
                for (int i = 0; i < size; i++)
                {
                    board[x - i, y] = 'S';
                }
                break;
            case 'D':
                for (int i = 0; i < size; i++)
                {
                    board[x + i, y] = 'S';
                }
                break;
        }
    }

    static void PlayerTurn(char[,] computerBoard, char[,] playerGuessBoard)
    {
        Console.Write("Enter row to attack (0-9): ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter column to attack (A-J): ");
        int y = Console.ReadLine()[0] - 'A';

        if (computerBoard[x, y] == 'S')
        {
            Console.WriteLine("Hit!");
            playerGuessBoard[x, y] = 'X';
        }
        else
        {
            Console.WriteLine("Miss!");
            playerGuessBoard[x, y] = 'O';
        }
    }

    static void ComputerTurn(char[,] playerBoard, char[,] computerGuessBoard)
    {
        Random rand = new Random();
        int x, y;
        do
        {
            x = rand.Next(10);
            y = rand.Next(10);
        } while (computerGuessBoard[x, y] != '~');

        if (playerBoard[x, y] == 'S')
        {
            Console.WriteLine("Computer hit your ship!");
            computerGuessBoard[x, y] = 'X';
        }
        else
        {
            Console.WriteLine("Computer missed!");
            computerGuessBoard[x, y] = 'O';
        }
    }

    static bool CheckWin(char[,] guessBoard)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (guessBoard[i, j] == '~')
                {
                    return false;
                }
            }
        }
        return true;
    }
}
