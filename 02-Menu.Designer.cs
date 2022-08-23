namespace kibelezaKaique
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkFuncionario = new System.Windows.Forms.CheckBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAguardar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.pctSobre = new System.Windows.Forms.PictureBox();
            this.pctBanner = new System.Windows.Forms.PictureBox();
            this.pctRelatorio = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctContato = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Controls.Add(this.lblData);
            this.pnlMenu.Controls.Add(this.textBox1);
            this.pnlMenu.Controls.Add(this.txtCliente);
            this.pnlMenu.Controls.Add(this.chkCliente);
            this.pnlMenu.Controls.Add(this.chkFuncionario);
            this.pnlMenu.Controls.Add(this.cmbStatus);
            this.pnlMenu.Controls.Add(this.lblStatus);
            this.pnlMenu.Controls.Add(this.pctSair);
            this.pnlMenu.Controls.Add(this.btnAgendar);
            this.pnlMenu.Controls.Add(this.btnEditar);
            this.pnlMenu.Controls.Add(this.btnAguardar);
            this.pnlMenu.Controls.Add(this.btnFinalizar);
            this.pnlMenu.Controls.Add(this.btnCancelar);
            this.pnlMenu.Controls.Add(this.btnAprovar);
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.pctEmail);
            this.pnlMenu.Controls.Add(this.pctSobre);
            this.pnlMenu.Controls.Add(this.pctBanner);
            this.pnlMenu.Controls.Add(this.pctRelatorio);
            this.pnlMenu.Controls.Add(this.pctFuncionario);
            this.pnlMenu.Controls.Add(this.pctServico);
            this.pnlMenu.Controls.Add(this.pctContato);
            this.pnlMenu.Controls.Add(this.pctCliente);
            this.pnlMenu.Controls.Add(this.pctLogo);
            this.pnlMenu.Location = new System.Drawing.Point(75, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1000, 600);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(3, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 13);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "00:00:00";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 3);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "00/00/0000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(342, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(401, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCliente.Location = new System.Drawing.Point(225, 23);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(75, 21);
            this.chkCliente.TabIndex = 1;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkFuncionario
            // 
            this.chkFuncionario.AutoSize = true;
            this.chkFuncionario.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFuncionario.Location = new System.Drawing.Point(224, 50);
            this.chkFuncionario.Name = "chkFuncionario";
            this.chkFuncionario.Size = new System.Drawing.Size(111, 21);
            this.chkFuncionario.TabIndex = 2;
            this.chkFuncionario.Text = "Funcionário";
            this.chkFuncionario.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ARPOVADA",
            "CANCELADO",
            "FINALIZADO",
            "AGUARDANDO"});
            this.cmbStatus.Location = new System.Drawing.Point(807, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(206)))), ((int)(((byte)(210)))));
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(749, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // pctSair
            // 
            this.pctSair.Image = global::kibelezaKaique.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(934, 3);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(60, 60);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 17;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(845, 347);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(150, 50);
            this.btnAgendar.TabIndex = 11;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(845, 293);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 50);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAguardar
            // 
            this.btnAguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAguardar.FlatAppearance.BorderSize = 0;
            this.btnAguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAguardar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAguardar.ForeColor = System.Drawing.Color.White;
            this.btnAguardar.Location = new System.Drawing.Point(845, 239);
            this.btnAguardar.Name = "btnAguardar";
            this.btnAguardar.Size = new System.Drawing.Size(150, 50);
            this.btnAguardar.TabIndex = 9;
            this.btnAguardar.Text = "Aguardar";
            this.btnAguardar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(845, 185);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 50);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(845, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 50);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAprovar.FlatAppearance.BorderSize = 0;
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.Color.White;
            this.btnAprovar.Location = new System.Drawing.Point(845, 77);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(150, 50);
            this.btnAprovar.TabIndex = 6;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(342, 77);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(495, 321);
            this.dgvMenu.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblUsuario.Location = new System.Drawing.Point(0, 566);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(1000, 34);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "USUÁRIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::kibelezaKaique.Properties.Resources.btnEmail;
            this.pctEmail.Location = new System.Drawing.Point(830, 398);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(165, 165);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmail.TabIndex = 8;
            this.pctEmail.TabStop = false;
            this.pctEmail.Click += new System.EventHandler(this.pctEmail_Click);
            // 
            // pctSobre
            // 
            this.pctSobre.Image = global::kibelezaKaique.Properties.Resources.btnSobre;
            this.pctSobre.Location = new System.Drawing.Point(500, 398);
            this.pctSobre.Name = "pctSobre";
            this.pctSobre.Size = new System.Drawing.Size(165, 165);
            this.pctSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSobre.TabIndex = 7;
            this.pctSobre.TabStop = false;
            // 
            // pctBanner
            // 
            this.pctBanner.Image = global::kibelezaKaique.Properties.Resources.btnBanner;
            this.pctBanner.Location = new System.Drawing.Point(335, 398);
            this.pctBanner.Name = "pctBanner";
            this.pctBanner.Size = new System.Drawing.Size(165, 165);
            this.pctBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBanner.TabIndex = 6;
            this.pctBanner.TabStop = false;
            // 
            // pctRelatorio
            // 
            this.pctRelatorio.Image = global::kibelezaKaique.Properties.Resources.btnRelatorio;
            this.pctRelatorio.Location = new System.Drawing.Point(170, 398);
            this.pctRelatorio.Name = "pctRelatorio";
            this.pctRelatorio.Size = new System.Drawing.Size(165, 165);
            this.pctRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRelatorio.TabIndex = 5;
            this.pctRelatorio.TabStop = false;
            this.pctRelatorio.Click += new System.EventHandler(this.pctRelatorio_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::kibelezaKaique.Properties.Resources.btnFuncionario;
            this.pctFuncionario.Location = new System.Drawing.Point(5, 398);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(165, 165);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuncionario.TabIndex = 4;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctServico
            // 
            this.pctServico.Image = global::kibelezaKaique.Properties.Resources.btnServico;
            this.pctServico.Location = new System.Drawing.Point(170, 233);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(165, 165);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctServico.TabIndex = 3;
            this.pctServico.TabStop = false;
            this.pctServico.Click += new System.EventHandler(this.pctServico_Click);
            // 
            // pctContato
            // 
            this.pctContato.Image = global::kibelezaKaique.Properties.Resources.btnContato;
            this.pctContato.Location = new System.Drawing.Point(665, 398);
            this.pctContato.Name = "pctContato";
            this.pctContato.Size = new System.Drawing.Size(165, 165);
            this.pctContato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctContato.TabIndex = 2;
            this.pctContato.TabStop = false;
            this.pctContato.Click += new System.EventHandler(this.pctContato_Click);
            // 
            // pctCliente
            // 
            this.pctCliente.Image = global::kibelezaKaique.Properties.Resources.btnCliente;
            this.pctCliente.Location = new System.Drawing.Point(5, 233);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(165, 165);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCliente.TabIndex = 1;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::kibelezaKaique.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(5, 77);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(330, 150);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.PictureBox pctSobre;
        private System.Windows.Forms.PictureBox pctBanner;
        private System.Windows.Forms.PictureBox pctRelatorio;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.PictureBox pctContato;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAguardar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckBox chkFuncionario;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}