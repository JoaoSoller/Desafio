using CadastroCarros.DAO;
using CadastroCarros.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Controller
{
    class CarroController
    {
        private CarroRepositorio Repositorio;

        public CarroController()
        {
            Repositorio = new CarroRepositorio();
        }
        public Boolean Salvar(CarroModel carro)
        {  
            return Repositorio.SaveOrUpdate(carro);
        }

        public Boolean Deletar(int id)
        {
            return Repositorio.Delete(id) > 0;
        }
       

        public DataTable GetAll()
        {
            return Repositorio.ListarCarros();
        }

        public CarroModel GetCarro(int id)
        {
            return Repositorio.FindById(id);
        }
    }
}
