using CadastroCarros.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCarros.View
{
    public partial class ListarMarcaView : Form
    {
       private ModeloController modeloController;
        public ListarMarcaView(DataTable data)
        {
            modeloController = new ModeloController();
            InitializeComponent();
            dgb_Marca.DataSource = data;    
        }

        private void dgb_Marca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgb_Marca.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var id = dgb_Marca.Rows[e.RowIndex].Cells[0].Value.ToString();
                _ = modeloController.GetModeloAsync(Convert.ToInt32(id));
            }
            else
                Console.WriteLine("A linha ou célula selecionada não contém um valor válido.");
            
            
        }
    }
}
