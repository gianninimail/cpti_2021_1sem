using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class PessoaCtrl
    {
        public Boolean SalvarPessoaNoArquivo(Pessoa _pessoa)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.SalvarPessoaNoArquivo(_pessoa);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
