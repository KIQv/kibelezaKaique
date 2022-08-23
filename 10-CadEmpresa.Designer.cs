namespace kibelezaKaique
{
    partial class frmCadEmpresa
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
            this.pnlCadEmpresa = new System.Windows.Forms.Panel();
            this.pnlTelefoneEmpresa = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvTelefoneEmpresa = new System.Windows.Forms.DataGridView();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.radCpf = new System.Windows.Forms.RadioButton();
            this.radCnpj = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.mkdData = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.mkdCnpjCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCadEmpresa01 = new System.Windows.Forms.Label();
            this.pnlCadEmpresa.SuspendLayout();
            this.pnlTelefoneEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadEmpresa
            // 
            this.pnlCadEmpresa.BackgroundImage = global::kibelezaKaique.Properties.Resources.empresa;
            this.pnlCadEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadEmpresa.Controls.Add(this.pnlTelefoneEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.pctSair);
            this.pnlCadEmpresa.Controls.Add(this.radCpf);
            this.pnlCadEmpresa.Controls.Add(this.radCnpj);
            this.pnlCadEmpresa.Controls.Add(this.txtEmail);
            this.pnlCadEmpresa.Controls.Add(this.txtRazaoSocial);
            this.pnlCadEmpresa.Controls.Add(this.txtNomeEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.cmbHorario);
            this.pnlCadEmpresa.Controls.Add(this.mkdData);
            this.pnlCadEmpresa.Controls.Add(this.cmbStatus);
            this.pnlCadEmpresa.Controls.Add(this.mkdCnpjCpf);
            this.pnlCadEmpresa.Controls.Add(this.txtCodigo);
            this.pnlCadEmpresa.Controls.Add(this.lblHorario);
            this.pnlCadEmpresa.Controls.Add(this.lblDataCad);
            this.pnlCadEmpresa.Controls.Add(this.lblStatus);
            this.pnlCadEmpresa.Controls.Add(this.lblEmail);
            this.pnlCadEmpresa.Controls.Add(this.lblRazaoSocial);
            this.pnlCadEmpresa.Controls.Add(this.lblNomeEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.lblCodigo);
            this.pnlCadEmpresa.Controls.Add(this.btnSalvar);
            this.pnlCadEmpresa.Controls.Add(this.btnLimpar);
            this.pnlCadEmpresa.Controls.Add(this.lblCadEmpresa01);
            this.pnlCadEmpresa.Location = new System.Drawing.Point(100, 25);
            this.pnlCadEmpresa.Name = "pnlCadEmpresa";
            this.pnlCadEmpresa.Size = new System.Drawing.Size(1000, 600);
            this.pnlCadEmpresa.TabIndex = 0;
            // 
            // pnlTelefoneEmpresa
            // 
            this.pnlTelefoneEmpresa.BackgroundImage = global::kibelezaKaique.Properties.Resources.fonemepresa;
            this.pnlTelefoneEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefoneEmpresa.Controls.Add(this.btnExcluir);
            this.pnlTelefoneEmpresa.Controls.Add(this.btnAlterar);
            this.pnlTelefoneEmpresa.Controls.Add(this.btnCadastrar);
            this.pnlTelefoneEmpresa.Controls.Add(this.dgvTelefoneEmpresa);
            this.pnlTelefoneEmpresa.Enabled = false;
            this.pnlTelefoneEmpresa.Location = new System.Drawing.Point(180, 304);
            this.pnlTelefoneEmpresa.Name = "pnlTelefoneEmpresa";
            this.pnlTelefoneEmpresa.Size = new System.Drawing.Size(606, 217);
            this.pnlTelefoneEmpresa.TabIndex = 10;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(442, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 39);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(273, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 39);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(104, 175);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 39);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvTelefoneEmpresa
            // 
            this.dgvTelefoneEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvTelefoneEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefoneEmpresa.Location = new System.Drawing.Point(104, 3);
            this.dgvTelefoneEmpresa.Name = "dgvTelefoneEmpresa";
            this.dgvTelefoneEmpresa.Size = new System.Drawing.Size(499, 166);
            this.dgvTelefoneEmpresa.TabIndex = 0;
            this.dgvTelefoneEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefoneEmpresa_CellClick);
            this.dgvTelefoneEmpresa.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTelefoneEmpresa_ColumnHeaderMouseClick);
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pctSair.Image = global::kibelezaKaique.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(937, 3);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(60, 60);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 18;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // radCpf
            // 
            this.radCpf.AutoSize = true;
            this.radCpf.BackColor = System.Drawing.Color.Transparent;
            this.radCpf.Location = new System.Drawing.Point(260, 199);
            this.radCpf.Name = "radCpf";
            this.radCpf.Size = new System.Drawing.Size(45, 17);
            this.radCpf.TabIndex = 3;
            this.radCpf.Text = "CPF";
            this.radCpf.UseVisualStyleBackColor = false;
            this.radCpf.CheckedChanged += new System.EventHandler(this.radCpf_CheckedChanged);
            // 
            // radCnpj
            // 
            this.radCnpj.AutoSize = true;
            this.radCnpj.BackColor = System.Drawing.Color.Transparent;
            this.radCnpj.Checked = true;
            this.radCnpj.Location = new System.Drawing.Point(180, 199);
            this.radCnpj.Name = "radCnpj";
            this.radCnpj.Size = new System.Drawing.Size(52, 17);
            this.radCnpj.TabIndex = 2;
            this.radCnpj.TabStop = true;
            this.radCnpj.Text = "CNPJ";
            this.radCnpj.UseVisualStyleBackColor = false;
            this.radCnpj.CheckedChanged += new System.EventHandler(this.radCnpj_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(180, 272);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(764, 25);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(318, 217);
            this.txtRazaoSocial.Multiline = true;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(626, 25);
            this.txtRazaoSocial.TabIndex = 5;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEmpresa.Location = new System.Drawing.Point(180, 158);
            this.txtNomeEmpresa.Multiline = true;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(764, 25);
            this.txtNomeEmpresa.TabIndex = 1;
            this.txtNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeEmpresa_KeyPress);
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "06:00",
            "08:00",
            "10:00",
            "12:00",
            "14:00",
            "16:00"});
            this.cmbHorario.Location = new System.Drawing.Point(801, 427);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(143, 21);
            this.cmbHorario.TabIndex = 9;
            this.cmbHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorario_KeyPress);
            // 
            // mkdData
            // 
            this.mkdData.Enabled = false;
            this.mkdData.Location = new System.Drawing.Point(801, 377);
            this.mkdData.Mask = "00/00/0000";
            this.mkdData.Name = "mkdData";
            this.mkdData.Size = new System.Drawing.Size(143, 20);
            this.mkdData.TabIndex = 8;
            this.mkdData.ValidatingType = typeof(System.DateTime);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(801, 326);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(143, 21);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // mkdCnpjCpf
            // 
            this.mkdCnpjCpf.Location = new System.Drawing.Point(180, 222);
            this.mkdCnpjCpf.Mask = "00,000,000/0000-00";
            this.mkdCnpjCpf.Name = "mkdCnpjCpf";
            this.mkdCnpjCpf.Size = new System.Drawing.Size(132, 20);
            this.mkdCnpjCpf.TabIndex = 4;
            this.mkdCnpjCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdCnpjCpf_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(180, 103);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorario.Location = new System.Drawing.Point(797, 405);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(190, 19);
            this.lblHorario.TabIndex = 35;
            this.lblHorario.Text = "Horário de Atendimento:";
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCad.Location = new System.Drawing.Point(797, 355);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(141, 19);
            this.lblDataCad.TabIndex = 34;
            this.lblDataCad.Text = "Data de Cadastro:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(797, 304);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 19);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(181, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(314, 195);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(109, 19);
            this.lblRazaoSocial.TabIndex = 31;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(176, 136);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(147, 19);
            this.lblNomeEmpresa.TabIndex = 30;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(176, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 19);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(369, 547);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 50);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(636, 547);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCadEmpresa01
            // 
            this.lblCadEmpresa01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadEmpresa01.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmpresa01.ForeColor = System.Drawing.Color.White;
            this.lblCadEmpresa01.Location = new System.Drawing.Point(166, 0);
            this.lblCadEmpresa01.Name = "lblCadEmpresa01";
            this.lblCadEmpresa01.Size = new System.Drawing.Size(834, 72);
            this.lblCadEmpresa01.TabIndex = 28;
            this.lblCadEmpresa01.Text = "CADASTRO EMPRESA";
            this.lblCadEmpresa01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlCadEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.pnlCadEmpresa.ResumeLayout(false);
            this.pnlCadEmpresa.PerformLayout();
            this.pnlTelefoneEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadEmpresa;
        private System.Windows.Forms.MaskedTextBox mkdCnpjCpf;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblCadEmpresa01;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.MaskedTextBox mkdData;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RadioButton radCnpj;
        private System.Windows.Forms.RadioButton radCpf;
        private System.Windows.Forms.Panel pnlTelefoneEmpresa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvTelefoneEmpresa;
    }
}