namespace View
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.itmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.itsRelogio = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itsUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraTarefas = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.itsListarUsuarios = new System.Windows.Forms.ToolStripButton();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnsPrincipal.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.barraTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmArquivo,
            this.itmAbrir});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(1128, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // itmArquivo
            // 
            this.itmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmNovo,
            this.toolStripSeparator1,
            this.itmSair});
            this.itmArquivo.Name = "itmArquivo";
            this.itmArquivo.Size = new System.Drawing.Size(61, 20);
            this.itmArquivo.Text = "&Arquivo";
            // 
            // itmNovo
            // 
            this.itmNovo.Name = "itmNovo";
            this.itmNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itmNovo.Size = new System.Drawing.Size(180, 22);
            this.itmNovo.Text = "Novo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // itmSair
            // 
            this.itmSair.Name = "itmSair";
            this.itmSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.itmSair.Size = new System.Drawing.Size(180, 22);
            this.itmSair.Text = "Sair";
            // 
            // itmAbrir
            // 
            this.itmAbrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmTXT,
            this.loginToolStripMenuItem});
            this.itmAbrir.Name = "itmAbrir";
            this.itmAbrir.Size = new System.Drawing.Size(45, 20);
            this.itmAbrir.Text = "A&brir";
            // 
            // itmTXT
            // 
            this.itmTXT.Name = "itmTXT";
            this.itmTXT.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.itmTXT.Size = new System.Drawing.Size(203, 22);
            this.itmTXT.Text = "Arquivo TXT";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsRelogio,
            this.toolStripStatusLabel1,
            this.itsUsuarioLogado});
            this.barraStatus.Location = new System.Drawing.Point(0, 545);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(1128, 22);
            this.barraStatus.TabIndex = 1;
            this.barraStatus.Text = "Barra de Status";
            // 
            // itsRelogio
            // 
            this.itsRelogio.Name = "itsRelogio";
            this.itsRelogio.Size = new System.Drawing.Size(49, 17);
            this.itsRelogio.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // itsUsuarioLogado
            // 
            this.itsUsuarioLogado.Name = "itsUsuarioLogado";
            this.itsUsuarioLogado.Size = new System.Drawing.Size(30, 17);
            this.itsUsuarioLogado.Text = "User";
            // 
            // barraTarefas
            // 
            this.barraTarefas.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraTarefas.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.barraTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrar,
            this.itsListarUsuarios});
            this.barraTarefas.Location = new System.Drawing.Point(0, 24);
            this.barraTarefas.Name = "barraTarefas";
            this.barraTarefas.Size = new System.Drawing.Size(55, 521);
            this.barraTarefas.TabIndex = 2;
            this.barraTarefas.Text = "Barra de Tarefas";
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrar.Image = global::View.Properties.Resources.add_user_2;
            this.tsbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(52, 54);
            this.tsbCadastrar.Text = "toolStripButton1";
            this.tsbCadastrar.ToolTipText = "Cadastrar um Novo Usuário no Banco de Dados";
            this.tsbCadastrar.Click += new System.EventHandler(this.tsbCadastrar_Click);
            // 
            // itsListarUsuarios
            // 
            this.itsListarUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itsListarUsuarios.Image = global::View.Properties.Resources.lista_user;
            this.itsListarUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itsListarUsuarios.Name = "itsListarUsuarios";
            this.itsListarUsuarios.Size = new System.Drawing.Size(52, 54);
            this.itsListarUsuarios.Text = "Listar Usuários";
            this.itsListarUsuarios.ToolTipText = "Listar Usuários do Banco de Dados";
            this.itsListarUsuarios.Click += new System.EventHandler(this.itsListarUsuarios_Click);
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.logo_lasalle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraTarefas);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.mnsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Aula da Disciplina CPTI";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.barraTarefas.ResumeLayout(false);
            this.barraTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itmArquivo;
        private System.Windows.Forms.ToolStripMenuItem itmNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itmSair;
        private System.Windows.Forms.ToolStripMenuItem itmAbrir;
        private System.Windows.Forms.ToolStripMenuItem itmTXT;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itsRelogio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel itsUsuarioLogado;
        private System.Windows.Forms.ToolStrip barraTarefas;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton itsListarUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}