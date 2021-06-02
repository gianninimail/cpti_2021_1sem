using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class EstadoCtrl
    {
        public List<Estado> BuscarTodos()
        {
            try
            {
                EstadoDAO estadoDAO = new EstadoDAO();

                return estadoDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: " + ex.Message);
            }
        }
    }
}
