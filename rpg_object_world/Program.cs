using System;
using System.Data;
using RestSharp;


namespace rpg_object_world
{
	class MainClass
	{
		private static void createTestWorld(RPGWorld aWorld)
		{
			RPGRoom tmp;
			tmp=aWorld.addRoom("Library", "A Library");
			tmp.addObject("Book", "A simple book");

		}
		public static void Main(string[] args)
		{
			//RPGObject o;


			SimpleRESTClient src = new SimpleRESTClient();
			RPGWorld status=src.getStatus();
			Console.WriteLine("{0}",status.ToString());
			Console.WriteLine("End.");

		}
	}
}
