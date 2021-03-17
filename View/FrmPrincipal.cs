using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String msg1 = "Teste do";

            String msg2 = " btnOK";

            String msg = msg1 + msg2;

            MostrarMsg(msg);
        }

        private void MostrarMsg(String msg)
        {
            MessageBox.Show(msg);
        }
    }
}
