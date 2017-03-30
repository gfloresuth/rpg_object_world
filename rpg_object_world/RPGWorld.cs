using System;
using System.Collections.Generic;
namespace rpg_object_world
{
	public class RPGWorld : RPGObject
	{
		public string Version { get; set; }
		public string Status { get; set; }
		public Dictionary<string, RPGRoom> Rooms { get; set; }
		private RPGRoom _firstRoom;

		public RPGRoom FirstRoom {
			get
			{
				return _firstRoom;
			}
		}

		public RPGWorld()
		{
			Name = "";
			Description = "";
			_firstRoom = null;
			Rooms = new Dictionary<string, RPGRoom>();
		}
		public RPGWorld(string name, string description) : base(name, description)
		{
			Rooms = new Dictionary<string, RPGRoom>();
			_firstRoom = null;
		}
		public RPGRoom addRoom(string name, string description)
		{
			RPGRoom aRoom = new RPGRoom(name, description);
			Rooms.Add(name,aRoom);
			if (_firstRoom == null)
			{
				_firstRoom = aRoom;
			}
			return aRoom;
		}
		public override string ToString()
		{
			string output = "";
			output += string.Format("World {0}",Name);
			output += "\nROOMS:\n";
			foreach (string oName in Rooms.Keys)
			{
				output += "  " + Rooms[oName].ToString() + "\n";
			}
			return output;
		}

	}
}
