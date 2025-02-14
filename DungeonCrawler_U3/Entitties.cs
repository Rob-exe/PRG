using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;


namespace Game
{
	abstract class Entities {
		Random randGen = new Random();
		public int HP; //Player has 100 HP, monsters can have less
		public int DMG; //Arbitrary for now, it will not be a flat value
		public int DEF; //Will lessen damage
		public int ATK_SPD; //Determines who goes first
		public int MANA; //Used for casting spells (probably healing and maybe FIREBALL!!!!!!)
		public int CRIT; //Doubles damage, chance out of 100
		public int Attack() {
			if (randGen.Next(0,100) < CRIT)
			{
				return DMG * 2;
			} else
			{
				return DMG;
			}
		}
		public void GetDamage(int damage) {
			HP =- (damage - DEF);
		}
	}
	class Player : Entities
	{
		public Player() {
			this.HP = 100;
			this.DMG = 5;
			this.DEF = 2;
			this.ATK_SPD = 20;
			this.MANA = 2;
			this.CRIT = 20;
		}
		public Room Move(Room current, Room room1, Room room2, Room? room3 = null) {
			string playerInput;
			if (current.GetIntType() == 1)
			{
				Console.WriteLine("You have bested all the monsters in this room, there is nothing else for you here.");
			} else if (current.GetIntType() == 2)
			{
				Console.WriteLine("You have taken all the loot out of this room, there is nothing else for you here.");
			}
			while (true)
			{
				if (room3 == null)
				{
					Console.WriteLine("There are two paths ahead, which do you choose? " + room1.GetType() +" or " + room2.GetType() + "? Left or right?");
					playerInput = Console.ReadLine();
					if (playerInput.ToLower() == "left")
					{
						return room1;
					} else if (playerInput.ToLower() == "right")
					{
						return room2;
					} else
					{
						Console.WriteLine("Your input was incorrect, you hit a wall, get rekt");
						Console.WriteLine("-1 HP");
						HP =- 1;
					}
				} else {
					Console.WriteLine("There are three paths ahead, do you choose " + room1.GetType() + ", " + room2.GetType() + " or " + room3.GetType() + "? Left, center or right?");
					playerInput = Console.ReadLine();
					if (playerInput.ToLower() == "left")
					{
						return room1;
					}
					else if (playerInput.ToLower() == "center" || playerInput.ToLower() == "centre" || playerInput.ToLower() == "middle"){
						return room2;
					}
					else if (playerInput.ToLower() == "right")
					{
						return room3;
					} else
					{
						Console.WriteLine("Your input was incorrect, you hit a wall, get rekt");
						Console.WriteLine("-1 HP");
						HP =- 1;
					}
				}
			}		
		}
	}
	class Enemy : Entities
	{
		public Enemy() {
			this.HP = 50;
			this.DMG = 5;
			this.DEF = 1;
			this.ATK_SPD = 20;
			this.MANA = 0;
			this.CRIT = 10;
		}
		public int GetHealth()
		{return HP;}
		public bool IsDead() {
			if (HP == 0)
			{
				return true;
			}
			return false;
		}
	}
}