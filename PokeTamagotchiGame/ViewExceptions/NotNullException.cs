using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTamagotchiGame.ViewExceptions
{
    internal class NotNullException : Exception // This exception will be used in case the user pass nothing to the name;
            // Esta exeção vai ser utilizada caso o usuário não digite o nome na view
    {
        public NotNullException() {

            Console.WriteLine("O nome não pode ser nulo");
        }

        public NotNullException(string message): base(message) {}

    }
}
