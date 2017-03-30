using System;
using System.Collections.Generic;
namespace rpg_object_world
{
	public class RPGWorld : RPGObject
	{
		public Dictionary<string, RPGRoom> rooms;
		private RPGRoom _firstRoom;
		public RPGRoom FirstRoom {
			get
			{
				return _firstRoom;
			}
		}
		public RPGWorld(string name, string description) : base(name, description)
		{
			rooms = new Dictionary<string, RPGRoom>();
			_firstRoom = null;
		}
		public RPGRoom addRoom(string name, string description)
		{
			RPGRoom aRoom = new RPGRoom(name, description);
			rooms.Add(name,aRoom);
			if (_firstRoom == null)
			{
				_firstRoom = aRoom;
			}
			return aRoom;
		}

	}
}
