

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
			if (currentRoom.GetIntType() == 1) {
				while (!enemy.IsDead() && !player.IsDead())
				{
					player.Fight(enemy);
				}
				if (enemy.IsDead()){
					Console.WriteLine("You have bested all the foul beasts! You have scavenged some loot.");
				}
			} else if (currentRoom.GetIntType() == 2) {

			}
			player.Move(currentRoom, room1, room2, room3);
		}
	}
}