using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.ViewExceptions
{
    internal class CantBeANumberException : Exception
    {
        public CantBeANumberException() {

            Console.WriteLine("Não pode conter números");
        }
        public CantBeANumberException(string message) : base(message) { }
    }
}
