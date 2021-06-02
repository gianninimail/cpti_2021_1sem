using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class CidadeDAO
    {
        public List<Cidade> BuscarTodasPorEstadoID(Int32 _idEstado)
        {
            List<Cidade> listaCidades = new List<Cidade>();

            try
            {
                String SQL = "SELECT * FROM cidade WHERE estado_id = " + _idEstado + " ORDER BY descricao;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade c = new Cidade();

                    c.ID = data.GetInt32(0);
                    c.Descricao = data.GetString(1);

                    listaCidades.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return listaCidades;
        }
    }
}
