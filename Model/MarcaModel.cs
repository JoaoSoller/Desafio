using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Model
{
    class MarcaModel
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public MarcaModel()
        {
        }

        public MarcaModel(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

      

    }
}
