using System;
using System.Data;
using RestSharp;


namespace rpg_object_world
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			Console.WriteLine("Welcome to Object World!");
			Console.WriteLine("An RPG for learning about Object Oriented Programming");

			SimpleRESTClient src = new SimpleRESTClient();
			RPGStatus response = src.getStatus();

			Console.WriteLine("Testing connection...");
			Console.WriteLine("Version: {0}, Status: {1}", response.version, response.status);
			Console.WriteLine("End.");

		}
	}
}
