using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroCarros.Controller;
using CadastroCarros.Model;
using MySql.Data.MySqlClient;

namespace CadastroCarros
{
    public partial class CadastroCarroView : Form
    { 
        CarroController controller;
        private int idcarro, marcacodigo, modelocodigo;
        private string modelonome;
        MarcaController marcaController;
        ModeloController modeloController;
        
        public CadastroCarroView()
        {
            InitializeComponent();
        }

        public CadastroCarroView(int idcarro)
        {
            InitializeComponent();
            marcacodigo = 0;
            this.idcarro = idcarro;
            marcaController = new MarcaController();
            modeloController = new ModeloController();
            _ = PreencherCb_Marca();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            CarroModel carro = new CarroModel(int.Parse(txtID.Text), txtPlaca.Text, txtChassi.Text, marcacodigo,cb_modelo.Text, txtfabricacaoano.Text, txtmodeloano.Text, double.Parse(txtTabelaFipe.Text), double.Parse(txtValorVenda.Text), txtObservacoes.Text);
            controller = new CarroController();

            if (controller.Salvar(carro))
            {
                MessageBox.Show("Carro Salvo com Sucesso!",
                                "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controller.Deletar(int.Parse(txtID.Text)))
                MessageBox.Show("Carro Excluido com Sucesso!",
                                "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
                MessageBox.Show("Nenhum Carro foi excluido!",
                             "Sucesso!", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private void CadastroCarroView_Activated(object sender, EventArgs e)
        {
            controller = new CarroController();
            PreencherCarro(idcarro);
        }

        private void PreencherCarro(int id)
        {
            CarroModel carro = controller.GetCarro(id);

            txtID.Text = Convert.ToString(carro.Id);
            txtChassi.Text = carro.Chassi;
            txtPlaca.Text = carro.Placa;
            txtfabricacaoano.Text = carro.Fabricacaoano;
            txtmodeloano.Text = carro.Modeloano;
            txtObservacoes.Text = carro.Observacoes;
            txtTabelaFipe.Text = Convert.ToString(carro.Tabelafipe);
            txtValorVenda.Text = Convert.ToString(carro.Valorvenda);
            marcacodigo = carro.Marca;
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtChassi.Clear();
            txtPlaca.Clear();
            txtfabricacaoano.Clear();
            txtmodeloano.Clear();
            txtObservacoes.Clear();
            txtTabelaFipe.Clear();
            txtValorVenda.Clear();
        }
        private void FormatarDouble(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (decimal.TryParse(textBox.Text, out decimal number))
                {
                    textBox.Text = number.ToString("0.00");
                }
                else
                {
                    textBox.Text = "";
                }
            }
        }
      
        private void txtTabelaFipe_Leave(object sender, EventArgs e)
        {
            FormatarDouble(txtTabelaFipe);
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            FormatarDouble(txtValorVenda);
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back  && e.KeyChar != ',')
            {
                e.Handled = true; // Impede a entrada do caractere
            }
        }

        private void txtTabelaFipe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true; // Impede a entrada do caractere
            }
        }

        private void cb_marca_DataSourceChanged(object sender, EventArgs e)
        {
           
        }

        private async Task PreencherCb_Marca()
        { 
            DataTable dataTableMarca = await marcaController.GetAll();
            int i = 0,indice = 0;

            cb_marca.DisplayMember = "nome";
            cb_marca.ValueMember = "codigo";

            foreach (DataRow row in dataTableMarca.Rows)
            {
                cb_marca.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(row["codigo"]), row["nome"].ToString()));
               
                if (i != -1 && marcacodigo == Convert.ToInt32(row["codigo"]))
                {
                    indice = i;
                    i = -1;
                }
                i++;
            }
            cb_marca.SelectedIndex = indice;
        }

        private void cb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_marca.SelectedItem is KeyValuePair<int, string> selected)
            {
                marcacodigo = selected.Key;
                _ = PreencherCb_Modelo(marcacodigo);
            }
        }
        private async Task PreencherCb_Modelo(int codigo)
        {
            var modelos = await modeloController.findById(codigo);
            cb_modelo.DisplayMember = "nome";
            cb_modelo.ValueMember = "codigo";
            int i = 0, indice = 0;
            foreach (ModeloModel row in modelos.modelos)
            {
                cb_modelo.Items.Add(new KeyValuePair<int, string>(row.codigo, row.nome));
                if (codigo != 0 && row.codigo == modelocodigo)
                {
                    indice = i;
                    i = 0;
                }
                i++;
            }
            cb_modelo.SelectedIndex = indice;
        }
    }
}
