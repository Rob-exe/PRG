using System.Collections.Generic;
using System;


internal class Program
{
	private static void Main(string[] args)
	{
		char[,] battle = new char[10,10]{
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'},
			{'O','O','O','O','O','O','O','O','O','O'}
		}; //inicializace herniho pole
		Dictionary<char, int> ships = new Dictionary<char, int>(){
			{'L', 5},
			{'B', 4},
			{'K', 3},
			{'P', 3},
			{'T', 2}
		}; //slovnik pro velikost lode
		battle = ShipPlacement(battle); //Umisteni lodi

	}
	static char[,] ShipPlacement(char[,] args)
	{
		bool allShipsPlaced = false;
		char[,] setup = args;
		while (!allShipsPlaced)
		{
			PrintBattle(setup);
			Console.ReadKey();
			Console.Clear();
		}
		return setup;
	}
	static void PrintBattle(char[,] args)
	{
		for (int i = 0; i < args.GetLength(0); i++) 
		{ 
  			for (int j = 0; j < args.GetLength(1); j++) 
  			{ 
    			Console.Write(args[i, j] + " "); 
  			} 
  		Console.WriteLine(); 
		} 

	}
}