using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeApiConnection;
using Newtonsoft.Json;
using PokeTamagotchiGame.Model;
using static System.Net.Mime.MediaTypeNames;

namespace PokeTamagotchiGame.Controller
{
    internal class AdocaoMascote
    {
        private ConnectionApi _conexaoApi;
        internal AdocaoMascote() {

            this._conexaoApi = new ConnectionApi("https://pokeapi.co/api/v2/pokemon/");

        }

        internal Pokemon ListarPokemon(int offset)
        {
            string endereco = $"{offset}/";

            this._conexaoApi.CheckConnectionApi(endereco);

            return JsonConvert.DeserializeObject<Pokemon>(this._conexaoApi.ApiGet(endereco)); ;
        }

        internal void EscolherPokemon(int offset, Pokemon mascote) 
        {
             Console.WriteLine($"O pokenome {mascote.name} foi escolhido como mascote");

        }
    }
}
