using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Model
{
    class ModeloModel
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public ModeloModel(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public ModeloModel()
        {
        }
    }
}
