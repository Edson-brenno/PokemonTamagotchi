using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.ViewExceptions
{
    internal class CantBeSpecialCharacterExpeception : Exception
    {
        public CantBeSpecialCharacterExpeception() {

            Console.WriteLine("Não pode conter caracteres especiais");
        }
        public CantBeSpecialCharacterExpeception(string message) : base(message) { }
    }
}
