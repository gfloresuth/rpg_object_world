using System;
namespace rpg_object_world
{
	public class RPGRoom : RPGObject
	{
		public RPGRoom ExitN { set; get; }
		public RPGRoom ExitS { set; get; }
		public RPGRoom ExitE { set; get; }
		public RPGRoom ExitW { set; get; }
		public RPGRoom ExitUp { set; get; }
		public RPGRoom ExitDown { set; get; }
		public RPGRoom ExitRight { set; get; }
		public RPGRoom ExitLeft { set; get; }
		public RPGRoom()
		{
			
		}
		public RPGRoom(string aName, string aDescription) : base(aName, aDescription)
		{
			
		}
		public override string ToString()
		{
			string output = "";

			output += string.Format("Room {0}",Name);
			output +="\n";
			foreach (string oName in Objects.Keys)
			{
				output += "  "+Objects[oName].ToString()+"\n";
			}

			return output;
		}
	}
}
