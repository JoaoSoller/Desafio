using CadastroCarros.Model;
using CadastroCarros.Service;
using CadastroCarros.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Controller
{

    class MarcaController
    {
        MarcaService service;
        ListarMarcaView listarMarcaview; 

      
        public MarcaController()
        {
            service = new MarcaService();    
        }
        public async Task <DataTable> GetAll()
        {
            return await service.ListarMarcas();
        }

        public async Task VisualizarMarcaAsync()
        {
            DataTable data = await GetAll();
            listarMarcaview = new ListarMarcaView(data);
            listarMarcaview.Show();
        }

    }
}
