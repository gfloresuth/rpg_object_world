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

			RPGWorld mainWorld = new RPGWorld("RPG Object World","RPG Object World");
			createTestWorld(mainWorld);



			Console.WriteLine("Welcome to Object World!");
			Console.WriteLine("An RPG for learning about Object Oriented Programming");

			SimpleRESTClient src = new SimpleRESTClient();
			RPGStatus response;

			Console.WriteLine("Testing connection...");
			response = src.getStatus();
			Console.WriteLine("Version: {0}, Status: {1}", response.version, response.status);

			Console.WriteLine("{0}", mainWorld.ToString());
			Console.WriteLine("{0}", mainWorld.FirstRoom.ToString());


			Console.WriteLine("End.");

		}
	}
}
