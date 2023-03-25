using PokeApiConnection;
using PokeTamagotchiGame.Model;
using RestSharp;
using System.Text;
using Newtonsoft.Json;

try
{
    ConnectionApi tt = new ConnectionApi("https://pokeapi.co/api/v2/");

    var test = JsonConvert.DeserializeObject<Pokemon>(tt.ApiGet("pokemon/1/"));

    Console.WriteLine(test);




}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
