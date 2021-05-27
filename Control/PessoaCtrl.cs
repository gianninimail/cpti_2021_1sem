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
        #region Métodos com Arquivos
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

        public  Dictionary<Int64, Pessoa> ListarPessoasDoArquivo()
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.ListarPessoasDoArquivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion

        #region Operações com o Banco de Dados
        /*
        public Dictionary<Int64, Pessoa> BuscarTodos()
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.BuscarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        */
        public Object BD(string _comando, Object _parametro)
        {
            PessoaDAO dao = new PessoaDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Pessoa)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Pessoa)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "pessoa":
                    return dao.BuscarPorCPF((Int64)_parametro);
                default:
                    return "Comando inválido!";
            }
        }

        #endregion
    }
}
