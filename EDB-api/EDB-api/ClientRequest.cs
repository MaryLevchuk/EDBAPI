using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;

namespace EDB_api
{
    public class ClientRequest
    {
        public IRestClient Client;

        public ClientRequest()
        {
            Client = new RestClient();
            Client.BaseUrl = "";
        }
    }
}
