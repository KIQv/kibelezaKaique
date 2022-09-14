namespace kibelezaKaique
{
    partial class frmRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.radTelefone = new System.Windows.Forms.RadioButton();
            this.radInativo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.radEmpresa = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.lblTabela = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackgroundImage = global::kibelezaKaique.Properties.Resources.relatorio;
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.dgvRelatorio);
            this.pnlRelatorio.Controls.Add(this.pictureBox1);
            this.pnlRelatorio.Controls.Add(this.pnlFiltro);
            this.pnlRelatorio.Controls.Add(this.pnlTabela);
            this.pnlRelatorio.Controls.Add(this.btnSalvar);
            this.pnlRelatorio.Controls.Add(this.pctSair);
            this.pnlRelatorio.Location = new System.Drawing.Point(100, 25);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1000, 600);
            this.pnlRelatorio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kibelezaKaique.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(847, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlFiltro.Controls.Add(this.radTelefone);
            this.pnlFiltro.Controls.Add(this.radInativo);
            this.pnlFiltro.Controls.Add(this.radAtivo);
            this.pnlFiltro.Controls.Add(this.lblFiltro);
            this.pnlFiltro.Location = new System.Drawing.Point(169, 64);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(672, 60);
            this.pnlFiltro.TabIndex = 30;
            // 
            // radTelefone
            // 
            this.radTelefone.AutoSize = true;
            this.radTelefone.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radTelefone.ForeColor = System.Drawing.Color.White;
            this.radTelefone.Location = new System.Drawing.Point(269, 33);
            this.radTelefone.Name = "radTelefone";
            this.radTelefone.Size = new System.Drawing.Size(85, 21);
            this.radTelefone.TabIndex = 6;
            this.radTelefone.TabStop = true;
            this.radTelefone.Text = "Telefone";
            this.radTelefone.UseVisualStyleBackColor = true;
            // 
            // radInativo
            // 
            this.radInativo.AutoSize = true;
            this.radInativo.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radInativo.ForeColor = System.Drawing.Color.White;
            this.radInativo.Location = new System.Drawing.Point(129, 33);
            this.radInativo.Name = "radInativo";
            this.radInativo.Size = new System.Drawing.Size(73, 21);
            this.radInativo.TabIndex = 5;
            this.radInativo.TabStop = true;
            this.radInativo.Text = "Inativo";
            this.radInativo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radAtivo.ForeColor = System.Drawing.Color.White;
            this.radAtivo.Location = new System.Drawing.Point(3, 33);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(60, 21);
            this.radAtivo.TabIndex = 4;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "Ativo";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltro.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(0, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(672, 23);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRO";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlTabela.Controls.Add(this.radFuncionario);
            this.pnlTabela.Controls.Add(this.radEmpresa);
            this.pnlTabela.Controls.Add(this.radCliente);
            this.pnlTabela.Controls.Add(this.lblTabela);
            this.pnlTabela.Location = new System.Drawing.Point(169, 3);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(672, 60);
            this.pnlTabela.TabIndex = 29;
            // 
            // radFuncionario
            // 
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radFuncionario.ForeColor = System.Drawing.Color.White;
            this.radFuncionario.Location = new System.Drawing.Point(269, 32);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(110, 21);
            this.radFuncionario.TabIndex = 3;
            this.radFuncionario.TabStop = true;
            this.radFuncionario.Text = "Funcionario";
            this.radFuncionario.UseVisualStyleBackColor = true;
            // 
            // radEmpresa
            // 
            this.radEmpresa.AutoSize = true;
            this.radEmpresa.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radEmpresa.ForeColor = System.Drawing.Color.White;
            this.radEmpresa.Location = new System.Drawing.Point(129, 32);
            this.radEmpresa.Name = "radEmpresa";
            this.radEmpresa.Size = new System.Drawing.Size(88, 21);
            this.radEmpresa.TabIndex = 2;
            this.radEmpresa.TabStop = true;
            this.radEmpresa.Text = "Empresa";
            this.radEmpresa.UseVisualStyleBackColor = true;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.radCliente.ForeColor = System.Drawing.Color.White;
            this.radCliente.Location = new System.Drawing.Point(3, 32);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(74, 21);
            this.radCliente.TabIndex = 1;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // lblTabela
            // 
            this.lblTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTabela.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblTabela.ForeColor = System.Drawing.Color.White;
            this.lblTabela.Location = new System.Drawing.Point(0, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(672, 23);
            this.lblTabela.TabIndex = 0;
            this.lblTabela.Text = "TABELA";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(847, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 50);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.Transparent;
            this.pctSair.Image = global::kibelezaKaique.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(937, 3);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(60, 60);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 18;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.AllowUserToResizeColumns = false;
            this.dgvRelatorio.AllowUserToResizeRows = false;
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRelatorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelatorio.EnableHeadersVisualStyles = false;
            this.dgvRelatorio.Location = new System.Drawing.Point(169, 125);
            this.dgvRelatorio.MultiSelect = false;
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersVisible = false;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(828, 472);
            this.dgvRelatorio.TabIndex = 32;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaKaique.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnlRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.RadioButton radTelefone;
        private System.Windows.Forms.RadioButton radInativo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.RadioButton radFuncionario;
        private System.Windows.Forms.RadioButton radEmpresa;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRelatorio;
    }
}