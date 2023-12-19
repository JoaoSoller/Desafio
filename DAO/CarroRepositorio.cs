using CadastroCarros.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCarros.DAO
{
    public class CarroRepositorio
    {
        private MySqlConnection Conexao;
        private readonly string data_source = "datasource=localhost;username=root;password=;database=bancodesafio";
        private readonly string sql_insert = "INSERT INTO carro (placa, chassi, marca,modelo,fabricacaoano,modeloano,tabelafipe,valorvenda,Observacoes) " +
                                 "VALUES " +
                                 "(@placa, @chassi, @marca,@modelo,@fabricacaoano,@modeloano,@tabelafipe,@valorvenda,@observacoes) ";
        private readonly string sql_update = "UPDATE carro SET " +
                                 "Placa =@Placa , Chassi=@Chassi, Marca=@Marca, Modelo=@Modelo, fabricacaoano=@fabricacaoano, modeloano=@modeloano, tabelafipe=@tabelafipe, valorvenda=@valorvenda, Observacoes=@Observacoes   " +
                                      "WHERE id=@id ";
        private readonly string sql_delete = "delete from carro where id=@id";
        private readonly string sql_selectall = "SELECT * FROM carro";
        private readonly string sql_selectid = "SELECT * FROM carro where id=@id ";

        public Boolean SaveOrUpdate(CarroModel carro)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (carro.Id == 0)
                    cmd.CommandText = sql_insert;
                else
                {
                    cmd.CommandText = sql_update;
                    cmd.Parameters.AddWithValue("@id", carro.Id);
                }

                cmd.Parameters.AddWithValue("@placa", carro.Placa);
                cmd.Parameters.AddWithValue("@chassi", carro.Chassi);
                cmd.Parameters.AddWithValue("@modelo", carro.Modelo);
                cmd.Parameters.AddWithValue("@marca", carro.Marca);
                cmd.Parameters.AddWithValue("@fabricacaoano", carro.Fabricacaoano);
                cmd.Parameters.AddWithValue("@modeloano", carro.Modeloano);
                cmd.Parameters.AddWithValue("@tabelafipe", carro.Tabelafipe);
                cmd.Parameters.AddWithValue("@valorvenda", carro.Valorvenda);
                cmd.Parameters.AddWithValue("@observacoes", carro.Observacoes);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexao.Close();
                return true;

            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public int Delete(int id)
        {
            int rows;
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText = sql_delete;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                rows = cmd.ExecuteNonQuery();
                Conexao.Close();
                return rows;
            }
            catch (Exception ex)
            {
                Conexao.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ListarCarros()
        {
            DataTable table = new DataTable();
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao;
            cmd.CommandText = sql_selectall;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            
            MySqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }

        public CarroModel FindById(int id)
        {
            DataTable table = new DataTable();
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao;
            cmd.CommandText = sql_selectid;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            CarroModel carro = new CarroModel();

            if (reader.Read())
            {    
                carro.Id = Convert.ToInt32(reader["Id"]);
                carro.Marca = Convert.ToInt32(reader["marca"]);
                carro.Modelo = reader["modelo"].ToString();
                carro.Modeloano = reader["modeloano"].ToString();
                carro.Observacoes = reader["observacoes"].ToString();
                carro.Placa = reader["placa"].ToString();
                carro.Tabelafipe = Convert.ToDouble(reader["tabelafipe"]);
                carro.Valorvenda = Convert.ToDouble(reader["valorvenda"]);
                carro.Chassi = reader["chassi"].ToString();
                carro.Fabricacaoano = reader["fabricacaoano"].ToString();
            }
            return carro;
        }
    }
}
