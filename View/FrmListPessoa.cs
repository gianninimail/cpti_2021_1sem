using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace View
{
    public partial class FrmListPessoa : Form
    {
        Dictionary<Int64, Pessoa> tabelaPessoas = new Dictionary<Int64, Pessoa>();
        public FrmListPessoa()
        {
            InitializeComponent();
        }

        private void FrmListPessoa_Load(object sender, EventArgs e)
        {
            //Chamar método para Carregar Dados do BD(Grid View)
            CarregarGrid("");
        }

        private void CarregarGrid(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                //Chamada para o Controller (busca de dados)
                PessoaCtrl ctrl = new PessoaCtrl();

                tabelaPessoas = ctrl.ListarPessoasDoArquivo();

                foreach (Pessoa item in tabelaPessoas.Values)
                {
                    dgvDados.Rows.Add(item.CPF, item.Nome, item.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow linha = dgvDados.SelectedRows[0];
                DataGridViewCell celula = linha.Cells[0];
                Int64 cpf = Convert.ToInt64(celula.Value.ToString());

                Pessoa p = tabelaPessoas[cpf];

                FrmCadPessoa formCadPessoa = new FrmCadPessoa();

                formCadPessoa.Tag = p;

                formCadPessoa.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
