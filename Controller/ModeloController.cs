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
    class ModeloController
    {
        ListarModelosView listarModelosView;
        ModeloService service;

        public async Task<ModeloAno> findById(int id)
        {
            return await service.ListarModelo(id);
        }

        public async Task GetModeloAsync(int id)
        {
            var dados = await findById(id);
            listarModelosView = new ListarModelosView(ConverterParaDataTable(dados.modelos));
            listarModelosView.ShowDialog();
        }
        static DataTable ConverterParaDataTable<T>(List<T> data)
        {
            DataTable table = new DataTable();
            var properties = typeof(T).GetProperties().Where(prop => prop.CanRead).ToList();

            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                table.Rows.Add(row);
            }
            return table;
        }
   
        public ModeloController()
        {
            service = new ModeloService();
        }
    }
}
