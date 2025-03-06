using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;


namespace DungeonCrawler_U3
{
	abstract class Entities {
		readonly Random randGen = new();
		public int HP; //Player has 100 HP, monsters can have less
		public int DMG; //Arbitrary for now, it will not be a flat value
		public int DEF; //Will lessen damage
		public int ATK_SPD; //Determines who goes first, tbi
		public int MANA; //Used for casting spells (probably healing and maybe FIREBALL!!!!!!), tbi
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
		public bool IsDead() {
			if (HP <= 0)
			{
				return true;
			}
			return false;
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
		public void Fight(Enemy enemy1, Enemy? enemy2 = null, Enemy? enemy3 = null)
		{
			if (enemy2 == null)
			{
				if (enemy1.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy1.Attack());
					enemy1.GetDamage(Attack());
				} else if (ATK_SPD >= enemy1.ATK_SPD) 
				{
					enemy1.GetDamage(Attack());
					GetDamage(enemy1.Attack());
				}
			} else if (enemy3 == null) {
				if (enemy1.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy1.Attack());
					enemy1.GetDamage(Attack());
				} else if (ATK_SPD >= enemy1.ATK_SPD) 
				{
					enemy1.GetDamage(Attack());
					GetDamage(enemy1.Attack());
				} else if (enemy2.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy2.Attack());
					enemy2.GetDamage(Attack());
				} else if (ATK_SPD >= enemy2.ATK_SPD) 
				{
					enemy2.GetDamage(Attack());
					GetDamage(enemy2.Attack());
				}
			} else {
				if (enemy1.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy1.Attack());
					enemy1.GetDamage(Attack());
				} else if (ATK_SPD >= enemy1.ATK_SPD) 
				{
					enemy1.GetDamage(Attack());
					GetDamage(enemy1.Attack());
				} else if (enemy2.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy2.Attack());
					enemy2.GetDamage(Attack());
				} else if (ATK_SPD >= enemy2.ATK_SPD) 
				{
					enemy2.GetDamage(Attack());
					GetDamage(enemy2.Attack());
				} else if (enemy3.ATK_SPD > ATK_SPD) 
				{
					GetDamage(enemy3.Attack());
					enemy3.GetDamage(Attack());
				} else if (ATK_SPD >= enemy3.ATK_SPD) 
				{
					enemy3.GetDamage(Attack());
					GetDamage(enemy3.Attack());
				}
			}
		}
		public Room Move(Room current, Room room1, Room room2, Room? room3 = null) {
			string? playerInput;
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
					playerInput = Console.ReadLine() + "";
					if (string.Equals(playerInput.ToLower(), "left"))
					{
						return room1;
					} else if (string.Equals(playerInput.ToLower(), "right"))
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
					playerInput = Console.ReadLine() + "";
					if (string.Equals(playerInput.ToLower(), "left"))
					{
						return room1;
					}
					else if (string.Equals(playerInput.ToLower(), "center") || string.Equals(playerInput.ToLower(), "centre") || string.Equals(playerInput.ToLower(), "middle"))
					{
						return room2;
					}
					else if (string.Equals(playerInput.ToLower(), "right"))
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
		public Enemy(int HP = 0, int DMG = 0, int DEF = 0, int ATK_SPD = 0, int MANA = 0, int CRIT = 0) {
			this.HP = 50 + HP;
			this.DMG = 5 + DMG;
			this.DEF = 1 + DEF;
			this.ATK_SPD = 20 + ATK_SPD;
			this.MANA = 0 + MANA;
			this.CRIT = 10 + CRIT;
		}
		public int GetHealth()
		{return HP;}
	}
}