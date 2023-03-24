using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiConnection.ConnectionsExceptions
{
    internal class ConnectionNotSuccessful:Exception //This Exception will be used case of one error on the connection; Esta exceção vai ser utilizada em caso de error na conexão
    {

        internal ConnectionNotSuccessful()
        {
            Console.WriteLine("Houve um error ao conectar ao serviço");
        }
    }
}
