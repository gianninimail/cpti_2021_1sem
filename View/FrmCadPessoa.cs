using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace View
{
    public partial class FrmCadPessoa : Form
    {
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Método de criação do objeto do tipo Pessoa
                Pessoa pess = CriarPessoaDoForm();

                //Método para Armazenar Objeto Criado (Pessoa)
                PessoaCtrl control = new PessoaCtrl();
                if (control.SalvarPessoaNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Pessoa CriarPessoaDoForm()
        {
            Pessoa p = new Pessoa();

            String cpfSemPontos = mtbCpf.Text.Replace(".", "");
            String cpfSemTracos = cpfSemPontos.Replace("-", "");
            //mtbCpf.Text.Replace(".", "").Replace("-", "");
            p.CPF = Convert.ToInt64(cpfSemTracos);
            p.Nome = txbNome.Text;
            p.Cel = mtbCel.Text;
            p.Email = txbEmail.Text;
            p.TipoEnd = ltbTipoEnd.SelectedIndex;
            p.Logradouro = txbLogradouro.Text;
            p.Estado = cmbEstado.SelectedIndex;
            p.Cidade = cmbCidade.SelectedIndex;

            if (rdbCasado.Checked)
            {
                p.EstadoCivil = 0;
            }
            else if (rdbSolteiro.Checked)
            {
                p.EstadoCivil = 1;
            }
            else if (rdbSolteiro.Checked)
            {
                p.EstadoCivil = 2;
            }

            p.Filhos = ckbFilhos.Checked;
            p.Animais = ckbAnimais.Checked;
            p.Fumante = ckbFumante.Checked;

            return p;
        }

    }
}
