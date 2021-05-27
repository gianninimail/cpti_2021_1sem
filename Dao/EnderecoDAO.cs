using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class EnderecoDAO
    {
        public Endereco BuscarPorID(int _idEndereco)
        {
            Endereco p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM endereco WHERE id = {0};", _idEndereco);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Endereco();

                    p.ID = data.GetInt32(0);
                    p.TipoEnd = data.GetInt32(1);
                    p.Logradouro = data.GetString(2);
                    p.Cidade = data.GetInt32(3);
                    p.Estado = data.GetInt32(4);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR POR ID / " + ex.Message);
            }

            return p;
        }

        public int Inserir(Endereco _obj)
        {
            int idEnd = 0;

            try
            {
                String SQL = String.Format("INSERT INTO endereco (" +
                    "tipo_end," +
                    "logradouro," +
                    "cidade_id," +
                    "estado_id" +
                    ") " +
                    "VALUES ({0}, '{1}', {2}, {3});",
                    _obj.TipoEnd,
                    _obj.Logradouro,
                    _obj.Cidade,
                    _obj.Estado
                    );

                
                Object teste = BD.ExecutarInsertComRetornoValor(SQL, new List<SqlCeParameter>());
                idEnd = Convert.ToInt32(teste);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            return idEnd;
        }
    }
}
