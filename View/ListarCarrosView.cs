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
    public partial class ListarCarrosView : Form
    {
        CarroController carroController;
        MarcaController marcaController;
        ModeloController modeloController;
        DataTable dataTableMarca = new DataTable(); 
        public ListarCarrosView()
        {
            carroController = new CarroController();
            marcaController = new MarcaController();
            modeloController = new ModeloController();
            InitializeComponent();
            dgv_Carros.DataSource = carroController.GetAll();
        }

        private void dgv_Carros_CellDoubleClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Carros.Rows[e.RowIndex];
                CadastroCarroView cadastroCarro = new CadastroCarroView(Convert.ToInt32(row.Cells["ID"].Value));
                cadastroCarro.ShowDialog();
                dgv_Carros.DataSource = carroController.GetAll();
            }
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            _ = marcaController.VisualizarMarcaAsync();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroCarroView cadastroCarro = new CadastroCarroView();
            cadastroCarro.ShowDialog();
        }
    }
}
