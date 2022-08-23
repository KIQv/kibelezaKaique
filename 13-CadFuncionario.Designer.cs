namespace kibelezaKaique
{
    partial class frmCadFuncionario
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
            this.pnlCadFuncionario = new System.Windows.Forms.Panel();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbHorarioTrabalho = new System.Windows.Forms.ComboBox();
            this.lblHorarioTrabalho = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTelefoneFuncionario = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvTelefoneFuncionario = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.mkdData = new System.Windows.Forms.MaskedTextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblCadFuncionario = new System.Windows.Forms.Label();
            this.pnlCadFuncionario.SuspendLayout();
            this.pnlTelefoneFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadFuncionario
            // 
            this.pnlCadFuncionario.BackgroundImage = global::kibelezaKaique.Properties.Resources.funcionario;
            this.pnlCadFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadFuncionario.Controls.Add(this.cmbEmpresa);
            this.pnlCadFuncionario.Controls.Add(this.lblEmpresa);
            this.pnlCadFuncionario.Controls.Add(this.cmbHorarioTrabalho);
            this.pnlCadFuncionario.Controls.Add(this.lblHorarioTrabalho);
            this.pnlCadFuncionario.Controls.Add(this.cmbStatus);
            this.pnlCadFuncionario.Controls.Add(this.lblStatus);
            this.pnlCadFuncionario.Controls.Add(this.pnlTelefoneFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.txtEmail);
            this.pnlCadFuncionario.Controls.Add(this.txtSenha);
            this.pnlCadFuncionario.Controls.Add(this.txtNomeFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.mkdData);
            this.pnlCadFuncionario.Controls.Add(this.cmbNivel);
            this.pnlCadFuncionario.Controls.Add(this.txtCodigo);
            this.pnlCadFuncionario.Controls.Add(this.lblDataCad);
            this.pnlCadFuncionario.Controls.Add(this.lblNivel);
            this.pnlCadFuncionario.Controls.Add(this.lblEmail);
            this.pnlCadFuncionario.Controls.Add(this.lblSenha);
            this.pnlCadFuncionario.Controls.Add(this.lblNomeFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.lblCodigo);
            this.pnlCadFuncionario.Controls.Add(this.btnSalvar);
            this.pnlCadFuncionario.Controls.Add(this.btnLimpar);
            this.pnlCadFuncionario.Controls.Add(this.pctSair);
            this.pnlCadFuncionario.Controls.Add(this.lblCadFuncionario);
            this.pnlCadFuncionario.Location = new System.Drawing.Point(100, 25);
            this.pnlCadFuncionario.Name = "pnlCadFuncionario";
            this.pnlCadFuncionario.Size = new System.Drawing.Size(1000, 600);
            this.pnlCadFuncionario.TabIndex = 0;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbEmpresa.Location = new System.Drawing.Point(796, 437);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(191, 26);
            this.cmbEmpresa.TabIndex = 8;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmpresa.Location = new System.Drawing.Point(792, 415);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(78, 19);
            this.lblEmpresa.TabIndex = 63;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // cmbHorarioTrabalho
            // 
            this.cmbHorarioTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbHorarioTrabalho.FormattingEnabled = true;
            this.cmbHorarioTrabalho.Items.AddRange(new object[] {
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:0"});
            this.cmbHorarioTrabalho.Location = new System.Drawing.Point(793, 381);
            this.cmbHorarioTrabalho.Name = "cmbHorarioTrabalho";
            this.cmbHorarioTrabalho.Size = new System.Drawing.Size(191, 26);
            this.cmbHorarioTrabalho.TabIndex = 7;
            this.cmbHorarioTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorarioTrabalho_KeyPress);
            // 
            // lblHorarioTrabalho
            // 
            this.lblHorarioTrabalho.AutoSize = true;
            this.lblHorarioTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioTrabalho.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorarioTrabalho.Location = new System.Drawing.Point(789, 359);
            this.lblHorarioTrabalho.Name = "lblHorarioTrabalho";
            this.lblHorarioTrabalho.Size = new System.Drawing.Size(165, 19);
            this.lblHorarioTrabalho.TabIndex = 61;
            this.lblHorarioTrabalho.Text = "Horário de Trabalho:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(636, 268);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 26);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(632, 246);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 19);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Status:";
            // 
            // pnlTelefoneFuncionario
            // 
            this.pnlTelefoneFuncionario.BackgroundImage = global::kibelezaKaique.Properties.Resources.fonefuncionario;
            this.pnlTelefoneFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefoneFuncionario.Controls.Add(this.btnExcluir);
            this.pnlTelefoneFuncionario.Controls.Add(this.btnAlterar);
            this.pnlTelefoneFuncionario.Controls.Add(this.btnCadastrar);
            this.pnlTelefoneFuncionario.Controls.Add(this.dgvTelefoneFuncionario);
            this.pnlTelefoneFuncionario.Enabled = false;
            this.pnlTelefoneFuncionario.Location = new System.Drawing.Point(180, 304);
            this.pnlTelefoneFuncionario.Name = "pnlTelefoneFuncionario";
            this.pnlTelefoneFuncionario.Size = new System.Drawing.Size(606, 217);
            this.pnlTelefoneFuncionario.TabIndex = 52;
            this.pnlTelefoneFuncionario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTelefoneFuncionario_Paint);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(462, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 39);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(293, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 39);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(124, 175);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 39);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgvTelefoneFuncionario
            // 
            this.dgvTelefoneFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvTelefoneFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefoneFuncionario.Location = new System.Drawing.Point(104, 3);
            this.dgvTelefoneFuncionario.Name = "dgvTelefoneFuncionario";
            this.dgvTelefoneFuncionario.Size = new System.Drawing.Size(499, 166);
            this.dgvTelefoneFuncionario.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(180, 213);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(764, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(180, 268);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(220, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(180, 158);
            this.txtNomeFuncionario.Multiline = true;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(764, 26);
            this.txtNomeFuncionario.TabIndex = 1;
            this.txtNomeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFuncionario_KeyPress);
            // 
            // mkdData
            // 
            this.mkdData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mkdData.Location = new System.Drawing.Point(793, 326);
            this.mkdData.Name = "mkdData";
            this.mkdData.Size = new System.Drawing.Size(191, 24);
            this.mkdData.TabIndex = 6;
            this.mkdData.Text = "__/__/____";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.ItemHeight = 18;
            this.cmbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Outros"});
            this.cmbNivel.Location = new System.Drawing.Point(420, 268);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(191, 26);
            this.cmbNivel.TabIndex = 4;
            this.cmbNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNivel_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(180, 103);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 39;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCad.Location = new System.Drawing.Point(789, 304);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(141, 19);
            this.lblDataCad.TabIndex = 34;
            this.lblDataCad.Text = "Data de Cadastro:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNivel.Location = new System.Drawing.Point(416, 246);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(49, 19);
            this.lblNivel.TabIndex = 33;
            this.lblNivel.Text = "Nível:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(176, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSenha.Location = new System.Drawing.Point(176, 246);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 19);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(176, 136);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(173, 19);
            this.lblNomeFuncionario.TabIndex = 30;
            this.lblNomeFuncionario.Text = "Nome do Funcionario:";
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
            this.btnSalvar.TabIndex = 9;
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
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // lblCadFuncionario
            // 
            this.lblCadFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadFuncionario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblCadFuncionario.Location = new System.Drawing.Point(166, 0);
            this.lblCadFuncionario.Name = "lblCadFuncionario";
            this.lblCadFuncionario.Size = new System.Drawing.Size(834, 72);
            this.lblCadFuncionario.TabIndex = 28;
            this.lblCadFuncionario.Text = "CADASTRO FUNCIONARIO";
            this.lblCadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlCadFuncionario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.pnlCadFuncionario.ResumeLayout(false);
            this.pnlCadFuncionario.PerformLayout();
            this.pnlTelefoneFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoneFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadFuncionario;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbHorarioTrabalho;
        private System.Windows.Forms.Label lblHorarioTrabalho;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlTelefoneFuncionario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvTelefoneFuncionario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mkdData;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblCadFuncionario;
    }
}