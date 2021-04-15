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

namespace View
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            itsRelogio.Text = DateTime.Now.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();

            FrmLogin login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                User user = (User)login.Tag;

                itsUsuarioLogado.Text = user.Usuario;

                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.Show();
        }

        private void itsListarUsuarios_Click(object sender, EventArgs e)
        {
            FrmListPessoa f = new FrmListPessoa();

            f.ShowDialog();
        }
    }
}
