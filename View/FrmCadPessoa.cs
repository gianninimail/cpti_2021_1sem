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
                if ((Boolean)control.BD("inserir", pess))
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
            p.EnderecoPadrao.TipoEnd = ltbTipoEnd.SelectedIndex;
            p.EnderecoPadrao.Logradouro = txbLogradouro.Text;
            p.EnderecoPadrao.Estado = cmbEstado.SelectedIndex;
            p.EnderecoPadrao.Cidade = cmbCidade.SelectedIndex;

            if (rdbCasado.Checked)
            {
                p.EstadoCivil = 0;
            }
            else if (rdbSolteiro.Checked)
            {
                p.EstadoCivil = 1;
            }
            else if (rdbDivorciado.Checked)
            {
                p.EstadoCivil = 2;
            }

            p.Filhos = ckbFilhos.Checked;
            p.Animais = ckbAnimais.Checked;
            p.Fumante = ckbFumante.Checked;

            return p;
        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    mtbCpf.Enabled = false;

                    //Carregar os dados do Objeto Pessoa no formulário
                    Pessoa p = (Pessoa)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Pessoa _pessoa)
        {
            mtbCpf.Text = _pessoa.CPF.ToString();
            txbNome.Text = _pessoa.Nome;
            mtbCel.Text = _pessoa.Cel;
            txbEmail.Text = _pessoa.Email;
            ltbTipoEnd.SelectedIndex = _pessoa.EnderecoPadrao.TipoEnd;
            txbLogradouro.Text = _pessoa.EnderecoPadrao.Logradouro;
            cmbEstado.SelectedIndex = _pessoa.EnderecoPadrao.Estado;
            cmbCidade.SelectedIndex = _pessoa.EnderecoPadrao.Cidade;

            if (_pessoa.EstadoCivil == 0)
            {
                rdbCasado.Checked = true;
            }
            else if (_pessoa.EstadoCivil == 1)
            {
                rdbSolteiro.Checked = true;
            }
            else if (_pessoa.EstadoCivil == 2)
            {
                rdbDivorciado.Checked = true;
            }

            ckbAnimais.Checked = _pessoa.Animais;
            ckbFilhos.Checked = _pessoa.Filhos;
            ckbFumante.Checked = _pessoa.Fumante;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Método de criação do objeto do tipo Pessoa
                Pessoa pess = CriarPessoaDoForm();

                //Método para Armazenar Objeto Criado (Pessoa)
                PessoaCtrl control = new PessoaCtrl();
                if ((Boolean)control.BD("alterar", pess))
                {
                    MessageBox.Show("Alteração efetuada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR PESSOA: " + ex.Message);
            }
        }
    }
}
