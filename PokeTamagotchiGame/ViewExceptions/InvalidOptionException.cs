using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.ViewExceptions
{
    internal class InvalidOptionException : Exception
    {
        public InvalidOptionException() {

            Console.WriteLine("Opção escolhida é inválida");

        }

        public InvalidOptionException(string message) : base(message) { }

       
    }
}
