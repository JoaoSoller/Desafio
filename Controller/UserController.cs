
using CadastroCarros.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CadastroCarros.Controller
{

    class UserController
    {

        public UserController()
        {
        }

        static HttpClient httpClient;
        public async Task<Boolean> GetProductAsync(UserModelApi user)
        {
            httpClient = new HttpClient();
            string path = "https://test-api-y04b.onrender.com/signIn";

            var content = ToRequest(user);

            HttpResponseMessage response = await httpClient.PostAsync(path, (HttpContent)content);

            if (response.IsSuccessStatusCode) 
                return true;
            else 
                return false;
        }

        private object ToRequest(UserModelApi user)
        {
            string json = JsonConvert.SerializeObject(user);
            var data  = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}
