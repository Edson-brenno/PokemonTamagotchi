using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.ViewExceptions
{
    internal class CantBeWhiteSpaceException : Exception
    {
        public CantBeWhiteSpaceException() {

            Console.WriteLine("Error - Não pode conter espaço em branco");
        }
        public CantBeWhiteSpaceException(string message) : base(message) { }
    }
}
