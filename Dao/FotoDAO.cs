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
    public class FotoDAO
    {
        public Foto BuscarPorID(Int64 _cpfPessoa)
        {
            Foto foto = new Foto();
            try
            {
                String SQL = String.Format("SELECT imagem FROM foto WHERE pessoa_id = {0};", _cpfPessoa);

                foto.Imagem = (byte[])BD.ExecutarSelectImagem(SQL);

                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR POR ID FOTO / " + ex.Message);
            }

            return foto;
        }

        public int Inserir(Foto _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("INSERT INTO foto (" +
                    "pessoa_id," +
                    "imagem" +
                    ") " +
                    "VALUES (@pessoa_id, @imagem);",
                    _obj.CPF,
                    _obj.Imagem
                    );

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();
                parametros.Add(new SqlCeParameter("@pessoa_id", _obj.CPF));
                parametros.Add(new SqlCeParameter("@imagem", _obj.Imagem));


                linhasAfetasdas = BD.ExecutarIDU(SQL, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT FOTO / " + ex.Message);
            }

            return linhasAfetasdas;
        }
    }
}
