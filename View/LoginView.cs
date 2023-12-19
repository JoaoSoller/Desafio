using CadastroCarros.Controller;
using CadastroCarros.Model;
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
    public partial class LoginView : Form
    {
        UserController userControl;
        UserModelApi user;
        ListarCarrosView listarcarros;

        public LoginView()
        {
            InitializeComponent();
            userControl = new UserController();
            user = new UserModelApi();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            user.user = txtLogin.Text;
            user.password = txtSenha.Text;
            
            
            if (await userControl.GetProductAsync(user))
            {
                listarcarros = new ListarCarrosView();
                listarcarros.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválido.");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
