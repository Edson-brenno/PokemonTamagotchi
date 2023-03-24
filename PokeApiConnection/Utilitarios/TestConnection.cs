using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ApiConnection.Utilitarios
{
    internal class TestConnection //This class will check if the api e available; Esta classe vai verificar se a api está disponivel
    {

        internal static bool IsApiAvailable(string address)
        {
            RestClient client = new RestClient(address);

            RestRequest request = new RestRequest("", Method.Get);

            RestResponse response = client.ExecuteGet(request);

            return response.IsSuccessful;
        }

        internal static bool IsApiAvailable(string address, string endereco)
        {
            RestClient client = new RestClient(address);

            RestRequest request = new RestRequest(endereco, Method.Get);

            RestResponse response = client.ExecuteGet(request);

            return response.IsSuccessful;
        }

    }
}
