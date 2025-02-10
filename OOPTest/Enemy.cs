namespace ClassIntro
{
	internal class Enemy
	{

		public string name;
		int health;
		private int damage;
		int level;

	public Enemy(string name, int health, int damage, int level)
	{
		
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