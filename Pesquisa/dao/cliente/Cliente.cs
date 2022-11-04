using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.dao.cliente
{
    class Cliente
    {
        string oChave = "Data Source=10.39.45.44;Initial Catalog=Senac2022;Persist Security Info=True;User ID=Turma2022;Password=Turma2022@2022";
        public DataSet Lista_Cliente(string p_nome)
        {
            DataSet DataSetCliente = new DataSet();

            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
                string wQuery = $"select * from Customer_List where Name like '%{p_nome}%'";
                SqlDataAdapter Adapter = new SqlDataAdapter(wQuery, Conexao);
                Adapter.Fill(DataSetCliente);                
            }
            catch (Exception)
            {

                throw;
            }

            return DataSetCliente;
        }

        public void Incluir(string p_Name, string p_Contact, string p_Address, int p_Credit)
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Customer_List (Name, Contact, Address, credit)" +
                                                $"VALUES('{p_Name}'," +
                                                $"'{p_Contact}'," +
                                                $"'{p_Address}'," +
                                                $"'{p_Credit}')", Conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Alterar (string p_Name, string p_Contact, string p_Address, int p_Credit, int p_CusId)
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Customer_List SET" +
                                                $"Name = '{p_Name}'," +
                                                $"Contact = '{p_Contact}'," +
                                                $"Address = '{p_Address}," +
                                                $"credit = '{p_Credit}'" +
                                                $"WHERE CusId = {p_CusId}",Conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Apagar(int p_CusId)
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
                SqlCommand cmd = new SqlCommand($"delete from Customer_List WHERE CusId {p_CusId}", Conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
