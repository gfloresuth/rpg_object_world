using System;
using RestSharp;
namespace rpg_object_world
{
	public class SimpleRESTClient
	{
		RestClient client;
		public SimpleRESTClient()
		{
			client = new RestClient("https://darkuskyo.net/objectworld");
			client.AddDefaultHeader("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.110 Safari/537.36");
		}
		public RPGWorld getStatus()
		{
			RPGWorld data = null;
			var request = new RestRequest("/", Method.GET);
			IRestResponse<RPGWorld> response = client.Execute<RPGWorld>(request);
			data = response.Data;
			return data;
		}
	}
}
