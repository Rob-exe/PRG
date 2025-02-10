using System.Data;
using System.Security;

namespace ClassIntro {
	internal class Player
	{

		public string name;
		int health;
		private int damage;

		public Player(string name, int health, int damage) {
			this.name = name;
			this.health = health;
			this.damage = damage;
		}
		public void SetDamage(int value)
		{
			damage = value;
			if (damage <= 0)
			{
				damage = 1;
			}
		}
		public int GetDamage()
		{
			return damage;
		}
	}
}