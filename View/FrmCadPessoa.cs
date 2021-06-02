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
using System.IO;

namespace View
{
    public partial class FrmCadPessoa : Form
    {
        private byte[] vetorImagens;        
        
        public FrmCadPessoa()
        {
            InitializeComponent();
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
            p.Idade = Convert.ToInt32(nudIdade.Value);
            p.EnderecoPadrao.TipoEnd = ltbTipoEnd.SelectedIndex;
            p.EnderecoPadrao.Logradouro = txbLogradouro.Text;
            p.EnderecoPadrao.Estado = cmbEstado.SelectedIndex;
            p.EnderecoPadrao.Cidade = cmbCidade.SelectedIndex;

            p.Foto.CPF = p.CPF;
            p.Foto.Imagem = this.vetorImagens;

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
                CarregarComboEstados();

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
            nudIdade.Value = _pessoa.Idade;
            ptbFoto.Image = Image.FromStream(new MemoryStream(_pessoa.Foto.Imagem));
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

        private void ptbFoto_DoubleClick(object sender, EventArgs e)
        {
            try
            { 
                long tamanhoArquivoImagem = 0;

                //string strFn = @"D:\Google Drive\Fotos\IMG_20200904_124452.jpg";

                janelaArquivo.ShowDialog();
                string strFn = janelaArquivo.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.ptbFoto.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                this.vetorImagens = new byte[Convert.ToInt32(tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void CarregarComboEstados()
        {
            try
            {
                EstadoCtrl contrEstado = new EstadoCtrl();
                List<Estado> estados = contrEstado.BuscarTodos();

                cmbEstado.DisplayMember = "descricao";
                cmbEstado.ValueMember = "id";

                cmbEstado.DataSource = estados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO Carregar Combo Estados: " + ex.Message);
            }
        }

        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedValue != null)
            {
                //MessageBox.Show(cmbEstado.SelectedValue.ToString());
                cmbCidade.DisplayMember = "descricao";
                cmbCidade.ValueMember = "id";

                Estado estado = (Estado)cmbEstado.SelectedItem;

                cmbCidade.DataSource = estado.Cidades;
            }
        }
    }
}
