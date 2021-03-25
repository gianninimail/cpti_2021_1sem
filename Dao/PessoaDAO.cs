using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class PessoaDAO
    {
        public Boolean SalvarPessoaNoArquivo(Pessoa _pessoa)
        {
            bool resultado = false;

            String path = @"C:\Users\Thiago G Ramos\source\repos\AppAula_2021_1\bd.csv";

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_pessoa.CPF + ";");
                escritor.Write(_pessoa.Nome + ";");
                escritor.Write(_pessoa.Cel + ";");
                escritor.Write(_pessoa.Email + ";");
                escritor.Write(_pessoa.TipoEnd + ";");
                escritor.Write(_pessoa.Logradouro + ";");
                escritor.Write(_pessoa.Estado + ";");
                escritor.Write(_pessoa.Cidade + ";");
                escritor.Write(_pessoa.EstadoCivil + ";");
                escritor.Write(_pessoa.Animais + ";");
                escritor.Write(_pessoa.Filhos + ";");
                escritor.Write(_pessoa.Fumante + ";");

                //Preparar o arquivo para a próxima escrita, ou seja, adicionar quebra de linha
                escritor.WriteLine();

                escritor.Close();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return resultado;
        }
    }
}
