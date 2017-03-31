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
			SimpleRESTClient.localFile = Environment.GetEnvironmentVariable("RPG_OBJECT_WORLD_PATH")+"objectworld.json";
			Console.WriteLine(SimpleRESTClient.localFile);
			Console.WriteLine("Wait...");
			SimpleRESTClient src = new SimpleRESTClient();
			RPGWorld world=src.getStatus();
			if (world == null)
			{
				Console.WriteLine("No external data, reading local data...");
				world = src.getLocal();
			}

			if (world != null)
			{
				Console.WriteLine("{0}", world.ToString());
			}
			else
			{
				Console.WriteLine("No data.");
			}
			Console.WriteLine("End.");

		}
	}
}
