namespace kibelezaKaique
{
    partial class frmCadReserva
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
            this.pnlCalReserva = new System.Windows.Forms.Panel();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbHorarioReserva = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.calReserva = new System.Windows.Forms.MonthCalendar();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblHorarioReserva = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblCadServico = new System.Windows.Forms.Label();
            this.pnlCalReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalReserva
            // 
            this.pnlCalReserva.BackgroundImage = global::kibelezaKaique.Properties.Resources.reserva;
            this.pnlCalReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCalReserva.Controls.Add(this.cmbServico);
            this.pnlCalReserva.Controls.Add(this.lblServico);
            this.pnlCalReserva.Controls.Add(this.cmbCliente);
            this.pnlCalReserva.Controls.Add(this.lblCliente);
            this.pnlCalReserva.Controls.Add(this.cmbHorarioReserva);
            this.pnlCalReserva.Controls.Add(this.cmbFuncionario);
            this.pnlCalReserva.Controls.Add(this.lblFuncionario);
            this.pnlCalReserva.Controls.Add(this.cmbStatus);
            this.pnlCalReserva.Controls.Add(this.lblStatus);
            this.pnlCalReserva.Controls.Add(this.lblDataReserva);
            this.pnlCalReserva.Controls.Add(this.calReserva);
            this.pnlCalReserva.Controls.Add(this.txtObs);
            this.pnlCalReserva.Controls.Add(this.txtCodigo);
            this.pnlCalReserva.Controls.Add(this.lblHorarioReserva);
            this.pnlCalReserva.Controls.Add(this.lblObs);
            this.pnlCalReserva.Controls.Add(this.lblCodigo);
            this.pnlCalReserva.Controls.Add(this.btnSalvar);
            this.pnlCalReserva.Controls.Add(this.btnLimpar);
            this.pnlCalReserva.Controls.Add(this.pctSair);
            this.pnlCalReserva.Controls.Add(this.lblCadServico);
            this.pnlCalReserva.Location = new System.Drawing.Point(100, 25);
            this.pnlCalReserva.Name = "pnlCalReserva";
            this.pnlCalReserva.Size = new System.Drawing.Size(1000, 600);
            this.pnlCalReserva.TabIndex = 0;
            // 
            // cmbServico
            // 
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(431, 426);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(500, 28);
            this.cmbServico.TabIndex = 6;
            this.cmbServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServico_KeyPress);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblServico.Location = new System.Drawing.Point(427, 398);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(67, 19);
            this.lblServico.TabIndex = 57;
            this.lblServico.Text = "Serviço:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(431, 362);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(500, 28);
            this.cmbCliente.TabIndex = 5;
            this.cmbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCliente_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCliente.Location = new System.Drawing.Point(427, 334);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 55;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbHorarioReserva
            // 
            this.cmbHorarioReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHorarioReserva.FormattingEnabled = true;
            this.cmbHorarioReserva.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30"});
            this.cmbHorarioReserva.Location = new System.Drawing.Point(431, 234);
            this.cmbHorarioReserva.Name = "cmbHorarioReserva";
            this.cmbHorarioReserva.Size = new System.Drawing.Size(238, 28);
            this.cmbHorarioReserva.TabIndex = 2;
            this.cmbHorarioReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorarioReserva_KeyPress);
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(431, 298);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(500, 28);
            this.cmbFuncionario.TabIndex = 4;
            this.cmbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFuncionario_KeyPress);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFuncionario.Location = new System.Drawing.Point(427, 270);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(99, 19);
            this.lblFuncionario.TabIndex = 52;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "APROVADA",
            "CANCELADA",
            "FINALIZADA"});
            this.cmbStatus.Location = new System.Drawing.Point(693, 234);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(238, 28);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(689, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 19);
            this.lblStatus.TabIndex = 50;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataReserva.Location = new System.Drawing.Point(176, 206);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(130, 19);
            this.lblDataReserva.TabIndex = 49;
            this.lblDataReserva.Text = "Data da reserva:";
            // 
            // calReserva
            // 
            this.calReserva.Location = new System.Drawing.Point(180, 234);
            this.calReserva.Name = "calReserva";
            this.calReserva.TabIndex = 487;
            this.calReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calReserva_DateChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(180, 158);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(751, 25);
            this.txtObs.TabIndex = 1;
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(180, 103);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 39;
            // 
            // lblHorarioReserva
            // 
            this.lblHorarioReserva.AutoSize = true;
            this.lblHorarioReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioReserva.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorarioReserva.Location = new System.Drawing.Point(427, 206);
            this.lblHorarioReserva.Name = "lblHorarioReserva";
            this.lblHorarioReserva.Size = new System.Drawing.Size(148, 19);
            this.lblHorarioReserva.TabIndex = 33;
            this.lblHorarioReserva.Text = "Horário da reserva";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Britannic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblObs.Location = new System.Drawing.Point(176, 136);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(47, 19);
            this.lblObs.TabIndex = 30;
            this.lblObs.Text = "Obs.:";
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
            this.btnSalvar.Location = new System.Drawing.Point(667, 547);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 50);
            this.btnSalvar.TabIndex = 8;
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
            this.btnLimpar.Location = new System.Drawing.Point(847, 547);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 9;
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
            // lblCadServico
            // 
            this.lblCadServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadServico.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadServico.ForeColor = System.Drawing.Color.White;
            this.lblCadServico.Location = new System.Drawing.Point(166, 0);
            this.lblCadServico.Name = "lblCadServico";
            this.lblCadServico.Size = new System.Drawing.Size(834, 72);
            this.lblCadServico.TabIndex = 28;
            this.lblCadServico.Text = "CADASTRO DA RESERVA";
            this.lblCadServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlCalReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCalReserva_Load);
            this.pnlCalReserva.ResumeLayout(false);
            this.pnlCalReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalReserva;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblHorarioReserva;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblCadServico;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbHorarioReserva;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.MonthCalendar calReserva;
    }
}