namespace View
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.lblMsg);
            this.gpbLogin.Controls.Add(this.txbSenha);
            this.gpbLogin.Controls.Add(this.txbUsuario);
            this.gpbLogin.Controls.Add(this.label2);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Location = new System.Drawing.Point(22, 12);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(312, 169);
            this.gpbLogin.TabIndex = 0;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(41, 134);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(139, 13);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "Usuário ou Senha inválidos!";
            this.lblMsg.Visible = false;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(44, 94);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(179, 20);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.Text = "thiago";
            this.txbSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSenha_MouseClick);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(44, 46);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(179, 20);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.Text = "thiago";
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(170, 187);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // brnCancelar
            // 
            this.brnCancelar.Location = new System.Drawing.Point(259, 187);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(75, 23);
            this.brnCancelar.TabIndex = 5;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 222);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gpbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button brnCancelar;
    }
}