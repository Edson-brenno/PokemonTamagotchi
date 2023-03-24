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

            TestConnection check = new TestConnection(this.endereco);

            bool isAvailable = check.IsApiAvailable();

            if (isAvailable == false)
            {
                throw new ConnectionNotSuccessful();
            }
            
        }
        
       
    }
}