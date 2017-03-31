using System;
using RestSharp;
using System.IO;

namespace rpg_object_world
{
	public class SimpleRESTClient
	{
		public static string localFile;
		RestClient client;
		public SimpleRESTClient()
		{
			client = new RestClient("https://darkuskyo.net/objectworld");
			client.AddDefaultHeader("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.110 Safari/537.36");
		}
		public RPGWorld getLocal()
		{
			RPGWorld response = null;

			try
			{
				var content = File.ReadAllText(localFile);

				response = SimpleJson.DeserializeObject<RPGWorld>(content);
			}
			catch (Exception ex)
			{
				
			}

			return response;
		}
		public RPGWorld getStatus()
		{
			RPGWorld data = null;
			var request = new RestRequest("/", Method.GET);
			IRestResponse<RPGWorld> response = client.Execute<RPGWorld>(request);
			data = response.Data;
			if (data != null)
			{

				File.WriteAllText(localFile, response.Content);
			}
			return data;
		}
	}
}
