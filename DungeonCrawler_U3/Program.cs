

namespace DungeonCrawler_U3 {
	internal class Program
	{
		private static void Main(string[] args)
		{
			Random rng = new();
			Room currentRoom = new(1);
			Room room3 = new(rng.Next(1,3));
			Room room2 = new(rng.Next(1,3));
			Room room1 = new(rng.Next(1,3));
			Enemy enemy = new();
			Player player = new();
			Console.WriteLine(currentRoom.GetType());
			if (currentRoom.GetIntType() == 1){
				while (!enemy.IsDead() && player.IsDead())
				{
					if (enemy.ATK_SPD < player.ATK_SPD){
						enemy.GetDamage(player.Attack());
						player.GetDamage(enemy.Attack());
					} else {
						player.GetDamage(enemy.Attack());
						enemy.GetDamage(player.Attack());
					}
				}
			}
		}
	}
}