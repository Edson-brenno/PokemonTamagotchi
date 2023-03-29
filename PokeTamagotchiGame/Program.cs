using PokeApiConnection;
using PokeTamagotchiGame.Model;
using RestSharp;
using System.Text;
using Newtonsoft.Json;
using PokeTamagotchiGame;
using PokeTamagotchiGame.View;

try
{
    //ConnectionApi tt = new ConnectionApi("https://pokeapi.co/api/v2/");

    //var test = JsonConvert.DeserializeObject<Pokemon>(tt.ApiGet("pokemon/1/"));

    //Console.WriteLine(test);

    Menu menu = new Menu();

    menu.Main();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
