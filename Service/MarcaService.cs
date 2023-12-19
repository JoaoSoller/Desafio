using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using CadastroCarros.Model;

namespace CadastroCarros.Service
{
    class MarcaService
    {
        public async Task<DataTable> ListarMarcas()
        { 
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://parallelum.com.br/fipe/api/v1/carros/marcas");
            var jsonString = await response.Content.ReadAsStringAsync();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonString);
            return dataTable; 
        }
    }
}
