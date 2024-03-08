using System.Text.Json;
using RestSharp;
using System.IO;

RestClient client = new("https://pokeapi.co/api/v2/");

RestRequest request = new("pokemon/snorlax");

RestResponse sesponse = client.GetAsync(request).Result;

Console.WriteLine(Response.Content);
File.WriteAllText("Pokemon.json", Response.Content);
Console.ReadLine();