using CadastroCarros.Model;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CadastroCarros.Service
{
    class ModeloService
    {

        public async Task<ModeloAno> ListarModelo(int marca)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://parallelum.com.br/fipe/api/v1/carros/marcas/{marca}/modelos");

            ModeloAno modeloAno = new ModeloAno();
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                modeloAno  = JsonConvert.DeserializeObject<ModeloAno>(jsonString);
             }
            return modeloAno;
        }

    }

}
