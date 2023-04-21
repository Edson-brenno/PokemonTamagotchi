using RestSharp;
using PokeApiConnection.ConnectionsExceptions;
using ApiConnection.Utilitarios;


namespace PokeApiConnection
{
    public class ConnectionApi
    {
        
        internal string endereco { get; set; }

        internal RestClient Client { get; set; }

        public ConnectionApi(string address)
        {
            this.endereco = address;

            this.Client = new RestClient(address);

        }
        public void CheckConnectionApi()
        {

            bool isAvailable = TestConnection.IsApiAvailable(this.endereco);

            if (isAvailable == false)
            {
                throw new ConnectionNotSuccessful();
            }
            
        }

        public void CheckConnectionApi(string local)
        {

            bool isAvailable = TestConnection.IsApiAvailable(this.endereco);

            if (isAvailable == false)
            {
                throw new ConnectionNotSuccessful();
            }

        }

        public string ApiGet(string local)
        {

            this.CheckConnectionApi(local);

            RestRequest request = new RestRequest(local, Method.Get);

            RestResponse response = this.Client.Execute(request);

            return response.Content; 
            
        }
       
    }
}