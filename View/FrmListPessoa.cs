﻿using System;
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
                if (_filtro.Equals(""))
                {
                    tabelaPessoas = (Dictionary<Int64, Pessoa>)ctrl.BD("todos", null);
                }
                else
                {
                    if (_filtro.Length > 2)
                    {
                        tabelaPessoas = (Dictionary<Int64, Pessoa>)ctrl.BD("filtro", _filtro);
                    }
                }
                

                foreach (Pessoa p in tabelaPessoas.Values)
                {
                    dgvDados.Rows.Add(p.CPF, p.Nome, p.Email, p.EnderecoPadrao.ToString());
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

                CarregarGrid("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR: " + ex.Message);
            }
        }

        private void cmsItemDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = dgvDados.SelectedRows[0];
                DataGridViewCell celula = linha.Cells[0];
                Int64 cpf = Convert.ToInt64(celula.Value.ToString());

                tabelaPessoas.Remove(cpf);

                PessoaCtrl control = new PessoaCtrl();

                if ((Boolean)control.BD("deletar", cpf))
                {
                    CarregarGrid("");

                    MessageBox.Show(String.Format("Pessoa com CPF: {0} foi deletada com sucesso!", cpf));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR: " + ex.Message);
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid(txbFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO FAZER BUSCA: " + ex.Message);
            }
        }
    }
}
