using RestSharp;
using PokeApiConnection.ConnectionsExceptions;
using ApiConnection.Utilitarios;

namespace PokeApiConnection
{
    public class ConnectionApi
    {
        
        internal string endereco { get; set; }

        public ConnectionApi(string address)
        {
            this.endereco = address;
        }
        public void CheckConnectionApi()
        {

            bool isAvailable = TestConnection.IsApiAvailable(this.endereco);

            if (isAvailable == false)
            {
                throw new ConnectionNotSuccessful();
            }
            
        }
        
       
    }
}