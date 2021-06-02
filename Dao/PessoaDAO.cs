using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dao
{
    public class PessoaDAO
    {
        #region Manipulação de Dados com Arquivos

        //String dir = AppDomain.CurrentDomain.BaseDirectory;
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

        #endregion

        #region Métodos de Acesso ao Banco de Dados

        public Dictionary<Int64, Pessoa> BuscarTodos()
        {
            Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();
            
            try
            {
                String SQL = "SELECT * FROM pessoa ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pessoa p = new Pessoa();

                    p.CPF = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Idade = data.GetInt32(2);
                    p.Cel = data.GetString(3);
                    p.Email = data.GetString(4);
                    p.EstadoCivil = data.GetInt32(5);
                    p.Animais = data.GetBoolean(6);
                    p.Filhos = data.GetBoolean(7);
                    p.Fumante = data.GetBoolean(8);

                    EnderecoDAO daoEnd = new EnderecoDAO();
                    p.EnderecoPadrao = daoEnd.BuscarPorID(data.GetInt32(9));

                    FotoDAO daoFoto = new FotoDAO();
                    p.Foto = daoFoto.BuscarPorID(p.CPF);

                    mapaPessoas.Add(p.CPF, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaPessoas;
        }

        public Pessoa BuscarPorCPF(Int64 _cpf)
        {
            Pessoa p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pessoa WHERE cpf = {0};", _cpf);

                DataTableReader data = BD.ExecutarSelect(SQL);
                int idEnd = 0;
                if (data.Read())
                {
                    p = new Pessoa();

                    p.CPF = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Idade = data.GetInt32(2);
                    p.Cel = data.GetString(3);
                    p.Email = data.GetString(4);
                    p.EstadoCivil = data.GetInt32(5);
                    p.Animais = data.GetBoolean(6);
                    p.Filhos = data.GetBoolean(7);
                    p.Fumante = data.GetBoolean(8);
                    idEnd = data.GetInt32(9);
                }

                FotoDAO daoFoto = new FotoDAO();
                p.Foto = daoFoto.BuscarPorID(p.CPF);

                EnderecoDAO daoEnd = new EnderecoDAO();
                p.EnderecoPadrao = daoEnd.BuscarPorID(idEnd);
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Pessoa _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                EnderecoDAO daoEnd = new EnderecoDAO();
                int idEnd = daoEnd.Inserir(_obj.EnderecoPadrao);

                String SQL = String.Format("INSERT INTO pessoa ("+
                    "cpf," +
                    "nome," +
                    "idade," +
                    "cel," +
                    "email," +
                    "estado_civil," +
                    "animais," +
                    "filhos," +
                    "fumante," +
                    "endereco_padrao" +
                    ") " +
                    "VALUES ({0}, '{1}', {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}', {9});",
                    _obj.CPF,
                    _obj.Nome,
                    _obj.Idade,
                    _obj.Cel,
                    _obj.Email,
                    _obj.EstadoCivil,
                    _obj.Animais,
                    _obj.Filhos,
                    _obj.Fumante,
                    idEnd
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);

                if (linhasAfetasdas > 0)
                {
                    FotoDAO daoFoto = new FotoDAO();
                    daoFoto.Inserir(_obj.Foto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Deletar(Int64 _cpf)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM pessoa WHERE cpf = " + _cpf;

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Alterar(Pessoa _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE pessoa SET " +
                    "nome = '{0}'," +
                    "idade = {1}," +
                    "cel = '{2}'," +
                    "email = '{3}'," +
                    "estado_civil = {4}," +
                    "animais = '{5}'," +
                    "filhos = '{6}'," +
                    "fumante = '{7}'" +
                    " WHERE cpf = {8}",
                    _obj.Nome,
                    _obj.Idade,
                    _obj.Cel,
                    _obj.Email,
                    _obj.EstadoCivil,
                    _obj.Animais,
                    _obj.Filhos,
                    _obj.Fumante,
                    _obj.CPF
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<Int64, Pessoa> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();

            try
            {
                String SQL = "SELECT * FROM pessoa WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("cpf = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtro);
                }
                   
                SQL += " ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pessoa p = new Pessoa();

                    p.CPF = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Idade = data.GetInt32(2);
                    p.Cel = data.GetString(3);
                    p.Email = data.GetString(4);
                    p.EstadoCivil = data.GetInt32(5);
                    p.Animais = data.GetBoolean(6);
                    p.Filhos = data.GetBoolean(7);
                    p.Fumante = data.GetBoolean(8);

                    EnderecoDAO daoEnd = new EnderecoDAO();
                    p.EnderecoPadrao = daoEnd.BuscarPorID(data.GetInt32(9));

                    FotoDAO daoFoto = new FotoDAO();
                    p.Foto = daoFoto.BuscarPorID(p.CPF);

                    mapaPessoas.Add(p.CPF, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaPessoas;
        }

        #endregion
    }
}