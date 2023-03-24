using PokeApiConnection;
using RestSharp;

try
{
    ConnectionApi tt = new ConnectionApi("https://pokeapi.co/api/v2/");

    tt.CheckConnectionApi();
   
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
