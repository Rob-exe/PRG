using System.Collections.Generic;

namespace DungeonCrawler_U3
{
	enum RoomTypes
	{
		Fight = 1,
		Loot,
		Event
	}
	abstract class Rooms
	{

		public int roomType;
		

	}
	class Room : Rooms
	{
		public Room(int roomType) {
			this.roomType = roomType;
		}
		public new string GetType() {
			switch (roomType)
			{
				case (int)RoomTypes.Fight:
					return "Fight";
				case (int)RoomTypes.Loot:
					return "Loot";
				case (int)RoomTypes.Event:
					return "Event";
				default:
					break;
			}
			return "None";
		}
		public int GetIntType() {
			return roomType switch
			{
				(int)RoomTypes.Fight => 1,
				(int)RoomTypes.Loot => 2,
				(int)RoomTypes.Event => 3,
				_ => -1,
			};
		}
	}
}