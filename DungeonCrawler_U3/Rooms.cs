using System.Collections.Generic;

namespace Game
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
		List<string> contains;
		

	}
	class Room : Rooms
	{
		public Room(int roomType) {
			this.roomType = roomType;
		}
		public string GetType() {
			switch (this.roomType)
			{
				case (int) RoomTypes.Fight:
				return "Fight";
				case (int) RoomTypes.Loot:
				return "Loot";
				case (int) RoomTypes.Event:
				return "Event";
			}
			return "None";
		}
		public int GetIntType() {
			switch (this.roomType)
			{
				case (int) RoomTypes.Fight:
				return 1;
				case (int) RoomTypes.Loot:
				return 2;
				case (int) RoomTypes.Event:
				return 3;
			}
			return -1;
		}
	}
}