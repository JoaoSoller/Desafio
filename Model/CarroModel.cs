using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Model
{
    public class CarroModel
	{
		public int Id { get; set; }
		public String Placa { get; set; }
		public String Chassi { get; set; }
		public int Marca { get; set; }
		public String Modelo { get; set; }
		public String Fabricacaoano { get; set; }
		public String Modeloano { get; set; }
		public double Tabelafipe { get; set; }
		public double Valorvenda { get; set; }
		public String Observacoes{ get; set; }

        public CarroModel(int id, string placa, string chassi, int marca, String modelo, string fabricacaoano, string modeloano, double tabelafipe, double valorvenda, string observacoes)
        {
            Id = id;
            Placa = placa;
            Chassi = chassi;
            Marca = marca;
            Modelo = modelo;
            Fabricacaoano = fabricacaoano;
            Modeloano = modeloano;
            Tabelafipe = tabelafipe;
            Valorvenda = valorvenda;
            Observacoes = observacoes;
        }

        public CarroModel()
        {

        }
    }
}
