using PokeApiConnection;
using PokeTamagotchiGame.Model;
using RestSharp;
using System.Text;
using Newtonsoft.Json;
using PokeTamagotchiGame;
using PokeTamagotchiGame.View;
using PokeTamagotchiGame.Controller;

try
{
    //QTfav2BrVyCpz0b9
    //ConnectionApi tt = new ConnectionApi("https://pokeapi.co/api/v2/");

    //var test = JsonConvert.DeserializeObject<Pokemon>(tt.ApiGet("pokemon/1/"));

    //Console.WriteLine(test);

    //Console.BackgroundColor = ConsoleColor.Blue;
    //Console.ForegroundColor = ConsoleColor.White;
    //Console.SetWindowSize(90, 20);
    
    //Console.Clear();

    Menu menu = new Menu();

    menu.Main();

    //AdocaoMascote adotarPoke = new AdocaoMascote();

    //Console.WriteLine(adotarPoke.ListarPokemon(1));

    //Console.WriteLine(adotarPoke.EscolherPokemon(1));

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

