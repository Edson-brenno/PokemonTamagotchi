using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeApiConnection;
using Newtonsoft.Json;
using PokeTamagotchiGame.Model;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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

        internal void verificaSePossuiMascote(string local){

           if (File.ReadAllText(local).Contains(Nome)){

                throw new AlreadyHabeOnePetException();
           }
        }
        internal void EscolherPokemon(int offset, Pokemon mascote) 
        {
            String mascoteString = mascote.ToString();

            byte [] textoMascote = Encoding.Unicode.GetBytes(mascoteString.Replace(" ", ""));

            System.Console.WriteLine(textoMascote.Length);

            FileStream textoTest = new FileStream(, FileMode.Append, FileAccess.Write, FileShare.None, bufferSize: textoMascote.Length, useAsync: true);

            textoTest.WriteAsync(textoMascote, 0, textoMascote.Length);
             

        }

    }
}
