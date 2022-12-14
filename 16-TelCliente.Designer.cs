namespace kibelezaKaique
{
    partial class frmTelCliente
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
            this.pnlTelCliente = new System.Windows.Forms.Panel();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.mkdTel = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefone = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.pnlTelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelCliente
            // 
            this.pnlTelCliente.BackgroundImage = global::kibelezaKaique.Properties.Resources.fonecliente;
            this.pnlTelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelCliente.Controls.Add(this.cmbNomeCliente);
            this.pnlTelCliente.Controls.Add(this.mkdTel);
            this.pnlTelCliente.Controls.Add(this.txtDescricao);
            this.pnlTelCliente.Controls.Add(this.lblDescrição);
            this.pnlTelCliente.Controls.Add(this.cmbOperadora);
            this.pnlTelCliente.Controls.Add(this.lblOperadora);
            this.pnlTelCliente.Controls.Add(this.txtCodigo);
            this.pnlTelCliente.Controls.Add(this.lblNumeroTelefone);
            this.pnlTelCliente.Controls.Add(this.lblNomeCliente);
            this.pnlTelCliente.Controls.Add(this.lblCodigo);
            this.pnlTelCliente.Controls.Add(this.btnSalvar);
            this.pnlTelCliente.Controls.Add(this.btnLimpar);
            this.pnlTelCliente.Controls.Add(this.pctSair);
            this.pnlTelCliente.Location = new System.Drawing.Point(300, 125);
            this.pnlTelCliente.Name = "pnlTelCliente";
            this.pnlTelCliente.Size = new System.Drawing.Size(600, 400);
            this.pnlTelCliente.TabIndex = 0;
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Items.AddRange(new object[] {
            "VIVO",
            "CLARO",
            "TIM",
            "OI",
            "NEXTEL"});
            this.cmbNomeCliente.Location = new System.Drawing.Point(180, 91);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(268, 28);
            this.cmbNomeCliente.TabIndex = 56;
            // 
            // mkdTel
            // 
            this.mkdTel.Location = new System.Drawing.Point(180, 151);
            this.mkdTel.Mask = "(00) 00000-0000";
            this.mkdTel.Name = "mkdTel";
            this.mkdTel.Size = new System.Drawing.Size(143, 20);
            this.mkdTel.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(180, 275);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(220, 25);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.BackColor = System.Drawing.Color.Transparent;
            this.lblDescrição.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDescrição.Location = new System.Drawing.Point(176, 253);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(82, 19);
            this.lblDescrição.TabIndex = 55;
            this.lblDescrição.Text = "Descrição";
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.Items.AddRange(new object[] {
            "VIVO",
            "CLARO",
            "TIM",
            "OI",
            "NEXTEL"});
            this.cmbOperadora.Location = new System.Drawing.Point(180, 212);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(268, 28);
            this.cmbOperadora.TabIndex = 3;
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.BackColor = System.Drawing.Color.Transparent;
            this.lblOperadora.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperadora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblOperadora.Location = new System.Drawing.Point(176, 184);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(92, 19);
            this.lblOperadora.TabIndex = 52;
            this.lblOperadora.Text = "Operadora:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(180, 31);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 9;
            // 
            // lblNumeroTelefone
            // 
            this.lblNumeroTelefone.AutoSize = true;
            this.lblNumeroTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTelefone.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNumeroTelefone.Location = new System.Drawing.Point(176, 129);
            this.lblNumeroTelefone.Name = "lblNumeroTelefone";
            this.lblNumeroTelefone.Size = new System.Drawing.Size(161, 19);
            this.lblNumeroTelefone.TabIndex = 33;
            this.lblNumeroTelefone.Text = "Número de Telefone:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(176, 69);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(111, 19);
            this.lblNomeCliente.TabIndex = 30;
            this.lblNomeCliente.Text = "Nome Cliente:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(176, 9);
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
            this.btnSalvar.Location = new System.Drawing.Point(150, 323);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 50);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(358, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.Transparent;
            this.pctSair.Image = global::kibelezaKaique.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(537, 3);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(60, 60);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 18;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // frmTelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlTelCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefone Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelCliente_Load);
            this.pnlTelCliente.ResumeLayout(false);
            this.pnlTelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTelCliente;
        private System.Windows.Forms.MaskedTextBox mkdTel;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNumeroTelefone;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
    }
}