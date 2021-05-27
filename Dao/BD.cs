using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace Dao
{
    public static class BD
    {
        private static String strConn = @"Data Source = C:\Users\Thiago G Ramos\source\repos\AppAula_2021_1\data_base.sdf;Password=123;";
        private static SqlCeConnection conexao;

        private static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = strConn;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection(strConn);
                    conexao.Open();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ABRIR CONEXÃO: " + ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO FECHAR CONEXÃO: " + ex.Message);
            }
        }

        /*TROCADO PELO OUTRO MÉTODO PQ O DATA READER NÂO PERMITE ABRIR DUAS CONEXOES
        public static SqlCeDataReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                SqlCeDataReader data = comando.ExecuteReader();
                
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR SELECT: " + ex.Message);
            }

        }
        */
        
        public static DataTableReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);
                SqlCeDataAdapter db = new SqlCeDataAdapter(cmd);
                db.Fill(dt);

                DataTableReader data = dt.CreateDataReader();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR SELECT: " + ex.Message);
            }

        }

        public static int ExecutarIDU(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                int linhasAfetadas = comando.ExecuteNonQuery();

                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR ALTERAÇÃO: " + ex.Message);
            }
        }

        public static Object ExecutarInsertComRetornoValor(String _SQL, List<SqlCeParameter> _parametros)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                comando.Parameters.AddRange(_parametros.ToArray());
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT @@IDENTITY";
                Object valor = comando.ExecuteScalar();

                FecharConexao();

                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR INSERT COM RETORNO: " + ex.Message);
            }
        }
    }
}
