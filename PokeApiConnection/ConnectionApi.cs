using RestSharp;
using PokeApiConnection.ConnectionsExceptions;

namespace PokeApiConnection
{
    public class ConnectionApi
    {
        
        internal RestClient client { get; set; }

        public ConnectionApi(string Address)
        {
            client = new RestClient(Address);
        }
        public void TestConnectionApi()
        {

            RestRequest request = new RestRequest("https://pok", Method.Get);

            RestResponse Response = client.Execute(request);

            if (Response.IsSuccessful == false) {

                throw new ConnectionNotSuccessful();
            }
        }
        
       
    }
}