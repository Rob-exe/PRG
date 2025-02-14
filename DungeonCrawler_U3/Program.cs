

namespace Game {
	internal class Program
	{
		private static void Main(string[] args)
		{
			Random rng = new Random();
			Room currentRoom = new Room(1);
			Room room3 = new Room(1);
			Room room2 = new Room(2);
			Room room1 = new Room(1);
			Player player = new Player();
			Console.WriteLine(currentRoom.GetType());
			currentRoom = player.Move(currentRoom, room1, room2, room3);
			currentRoom = player.Move(currentRoom, room1, room2);
		}
	}
}