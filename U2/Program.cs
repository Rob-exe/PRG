class Program
{
    static void Main(string[] args)
    {
        char[,] playerBoard = GenerateBoards(true);
        char[,] enemyBoard = GenerateBoards(false);
    }
    static char[,] GenerateBoards(bool player) 
    {

        char[,] board = new char[10,10];
        for (int i = 0; i < board.GetLength(0); i++) //generate board
            {
                for (int x = 0; i < board.GetLength(1); x++) 
                {
                    board[i,x] = '~';
                }
            }
        if (player) //Generate board of player
        {
            while (true)
            {
                int length; //length of placed ship
                Console.WriteLine("Pick which ship you want to place (L (5), B (4), K (3), P (2), T (2)): ");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.L:
                    length = 5;
                    break;
                    case ConsoleKey.B:
                    length = 4;
                    break;
                    case ConsoleKey.K:
                    length = 3;
                    break;
                    case ConsoleKey.P:
                    length = 2;
                    break;
                    case ConsoleKey.T:
                    length = 2;
                    break;
                    default:
                    Console.WriteLine("Incorrect input, try again.");
                    break;
                }
            }
        } else if (!player) {

        }
        return board;
    }
}