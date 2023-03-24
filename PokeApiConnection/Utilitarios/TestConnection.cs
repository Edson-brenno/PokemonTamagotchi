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

        private string _Address { get;set;}
        internal TestConnection(string address)
        {
            this._Address = address;
        }

        internal bool IsApiAvailable()
        {
            RestRequest request = new RestRequest(this._Address, Method.Get);

            RestResponse response = new RestResponse(request);

            return response.IsSuccessful;
        }
    }
}
