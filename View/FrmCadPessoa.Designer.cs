
namespace View
{
    partial class FrmCadPessoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.ltbTipoEnd = new System.Windows.Forms.ListBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.ckbAnimais = new System.Windows.Forms.CheckBox();
            this.ckbFilhos = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckbFumante = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudIdade);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.mtbCel);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ptbFoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbCidade);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.txbLogradouro);
            this.groupBox2.Controls.Add(this.ltbTipoEnd);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Complementares";
            // 
            // ptbFoto
            // 
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFoto.Location = new System.Drawing.Point(6, 19);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(99, 114);
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Idade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(138, 35);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(145, 20);
            this.mtbCpf.TabIndex = 6;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(309, 35);
            this.txbNome.MaxLength = 150;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(202, 20);
            this.txbNome.TabIndex = 7;
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(138, 88);
            this.mtbCel.Mask = "(99) 00000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(145, 20);
            this.mtbCel.TabIndex = 8;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(309, 88);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(202, 20);
            this.txbEmail.TabIndex = 9;
            // 
            // nudIdade
            // 
            this.nudIdade.Location = new System.Drawing.Point(9, 167);
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(96, 20);
            this.nudIdade.TabIndex = 10;
            this.nudIdade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ltbTipoEnd
            // 
            this.ltbTipoEnd.FormattingEnabled = true;
            this.ltbTipoEnd.Items.AddRange(new object[] {
            "Av.",
            "Trv.",
            "Rod.",
            "Rua",
            "Est."});
            this.ltbTipoEnd.Location = new System.Drawing.Point(9, 54);
            this.ltbTipoEnd.Name = "ltbTipoEnd";
            this.ltbTipoEnd.Size = new System.Drawing.Size(120, 95);
            this.ltbTipoEnd.TabIndex = 0;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(138, 54);
            this.txbLogradouro.Multiline = true;
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(192, 95);
            this.txbLogradouro.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES"});
            this.cmbEstado.Location = new System.Drawing.Point(356, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(155, 21);
            this.cmbEstado.TabIndex = 2;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "Niterói",
            "Araruama",
            "São Paulo",
            "Belo Horizonte",
            "Vitória"});
            this.cmbCidade.Location = new System.Drawing.Point(356, 128);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(155, 21);
            this.cmbCidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Logradouro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cidade:";
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(30, 23);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 0;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(30, 61);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 1;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // ckbAnimais
            // 
            this.ckbAnimais.AutoSize = true;
            this.ckbAnimais.Location = new System.Drawing.Point(32, 24);
            this.ckbAnimais.Name = "ckbAnimais";
            this.ckbAnimais.Size = new System.Drawing.Size(86, 17);
            this.ckbAnimais.TabIndex = 2;
            this.ckbAnimais.Text = "Tem Animais";
            this.ckbAnimais.UseVisualStyleBackColor = true;
            // 
            // ckbFilhos
            // 
            this.ckbFilhos.AutoSize = true;
            this.ckbFilhos.Location = new System.Drawing.Point(32, 61);
            this.ckbFilhos.Name = "ckbFilhos";
            this.ckbFilhos.Size = new System.Drawing.Size(77, 17);
            this.ckbFilhos.TabIndex = 3;
            this.ckbFilhos.Text = "Tem Filhos";
            this.ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbDivorciado);
            this.groupBox4.Controls.Add(this.rdbCasado);
            this.groupBox4.Controls.Add(this.rdbSolteiro);
            this.groupBox4.Location = new System.Drawing.Point(63, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 133);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado Civil";
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(30, 99);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rdbDivorciado.TabIndex = 2;
            this.rdbDivorciado.TabStop = true;
            this.rdbDivorciado.Text = "Divorciado";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckbFumante);
            this.groupBox5.Controls.Add(this.ckbAnimais);
            this.groupBox5.Controls.Add(this.ckbFilhos);
            this.groupBox5.Location = new System.Drawing.Point(309, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 133);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Perfil";
            // 
            // ckbFumante
            // 
            this.ckbFumante.AutoSize = true;
            this.ckbFumante.Location = new System.Drawing.Point(32, 99);
            this.ckbFumante.Name = "ckbFumante";
            this.ckbFumante.Size = new System.Drawing.Size(77, 17);
            this.ckbFumante.TabIndex = 4;
            this.ckbFumante.Text = "É Fumante";
            this.ckbFumante.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(392, 605);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(473, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "3 x 4";
            // 
            // FrmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 640);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.ListBox ltbTipoEnd;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckbFilhos;
        private System.Windows.Forms.CheckBox ckbAnimais;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckbFumante;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
    }
}