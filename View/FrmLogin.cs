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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Usuario = txbUsuario.Text;
            user.Senha = txbUsuario.Text;

            if (ValidarLogin(user))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMsg.Visible = true;
            }
        }

        private bool ValidarLogin(User _user)
        {
            bool resultado = false;
            try
            {
                if (_user.Usuario.Equals("thiago") && _user.Senha.Equals("thiago"))
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EFETUAR LOGIN: " + ex.Message);
                return false;
            }

            return resultado;
        }
    }
}
