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
        //Caminho completo com Diretório de nome do Arquivo
        String path = @"C:\Users\Thiago G Ramos\source\repos\AppAula_2021_1\bd.csv";
        
        public Boolean SalvarPessoaNoArquivo(Pessoa _pessoa)
        {
            bool resultado = false;

            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_pessoa.CPF + ";");
                escritor.Write(_pessoa.Nome + ";");
                escritor.Write(_pessoa.Cel + ";");
                escritor.Write(_pessoa.Email + ";");
                escritor.Write(_pessoa.EnderecoPadrao.TipoEnd + ";");
                escritor.Write(_pessoa.EnderecoPadrao.Logradouro + ";");
                escritor.Write(_pessoa.EnderecoPadrao.Estado + ";");
                escritor.Write(_pessoa.EnderecoPadrao.Cidade + ";");
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
    
        public Dictionary<Int64, Pessoa> ListarPessoasDoArquivo()
        {
            Dictionary<Int64, Pessoa> tabelaPessoas = new Dictionary<Int64, Pessoa>();
            try
            {
                StreamReader leitor = new StreamReader(path);

                String arquivo = leitor.ReadToEnd();

                char[] divLinhas = { '\n' };//Linhas do Arquivo
                char[] divCampos = { ';' };//Colunas do Registro no Arquivo

                string[] linhas = arquivo.Split(divLinhas);//Divide todo arquivos em linhas (registros do arquivo)
                for (int i = 0; i < linhas.Length - 1; i++)//-1 por causa da linha em branco do arquivo
                {
                    string[] campos = linhas[i].Split(divCampos);

                    Pessoa p = new Pessoa();

                    p.CPF = Convert.ToInt64(campos[0]);
                    p.Nome = campos[1];
                    p.Cel = campos[2];
                    p.Email = campos[3];
                    p.EnderecoPadrao.TipoEnd = Convert.ToInt32(campos[4]);
                    p.EnderecoPadrao.Logradouro = campos[5];
                    p.EnderecoPadrao.Estado = Convert.ToInt32(campos[6]);
                    p.EnderecoPadrao.Cidade = Convert.ToInt32(campos[7]);
                    p.EstadoCivil = Convert.ToInt32(campos[8]);
                    p.Filhos = Convert.ToBoolean(campos[9]);
                    p.Animais = Convert.ToBoolean(campos[10]);
                    p.Fumante = Convert.ToBoolean(campos[11]);

                    tabelaPessoas.Add(p.CPF, p);
                }

                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaPessoas;
        }
    }
}
/*
if (campos[8].Equals("0"))
{
    p.EstadoCivil = 0;
}
else if (campos[8].Equals("1"))
{
    p.EstadoCivil = 1;
}
else if (campos[8].Equals("2"))
{
    p.EstadoCivil = 2;
}
*/