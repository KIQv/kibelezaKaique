using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaKaique
{
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto01_Click(object sender, EventArgs e)
        {
            btnFoto02.Focus();
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadServico.Location = new Point(this.Width / 2 - pnlCadServico.Width / 2, this.Height / 2 - pnlCadServico.Height / 2);
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void txtNomeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                btnFoto01.Focus();
            }
        }

        private void btnFoto02_Click(object sender, EventArgs e)
        {
            btnFoto03.Focus();
        }

        private void btnFoto03_Click(object sender, EventArgs e)
        {
            btnFoto04.Focus();
        }

        private void btnFoto04_Click(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTexto.Focus();
            }
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbTempo.Focus();
            }
        }

        private void cmbTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbEmpresa.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeServico.Text == String.Empty)
            {
                lblNomeServico.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o nome do serviço");
                txtNomeServico.Focus();
            }
            else if (txtValor.Text == String.Empty)
            {
                lblValor.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o valor do serviço");
                txtValor.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status do serviço");
                cmbStatus.Focus();
            }
            /*else if (Variaveis.atFotoServico != "S")
            {
                lblFoto01.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a foto do serviço");
            }*/
            else if (txtDescricao.Text == String.Empty)
            {
                lblDescricao.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a descrição do serviço");
                txtTexto.Focus();
            }
            else if (txtTexto.Text == String.Empty)
            {
                lblTexto.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o texto do serviço");
                cmbTempo.Focus();
            }
            else if (cmbTempo.Text == String.Empty)
            {
                lblTempoExecucao.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o tempo de execução do serviço");
                cmbEmpresa.Focus();
            }
            else if (cmbEmpresa.Text == String.Empty)
            {
                lblEmpresa.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a empresa");
                btnSalvar.Focus();
            }
            else
            {
                Variaveis.nomeServico = txtNomeServico.Text;
                Variaveis.valorServico = txtValor.Text;
                Variaveis.statusServico = cmbStatus.Text;
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadServico = DateTime.Parse(mkdData.Text);
                //Variaveis.fotoServico1 = "servico/" + nomeFoto;
                //Variaveis.fotoServico2 = "servico/" + nomeFoto;
                //Variaveis.fotoServico3 = "servico/" + nomeFoto;
                //Variaveis.fotoServico4 = "servico/" + nomeFoto;
                Variaveis.descServico = txtDescricao.Text;
                Variaveis.textoServico = txtTexto.Text;
                Variaveis.tempoExecServico = cmbTempo.Text;
                Variaveis.empresaServico = cmbEmpresa.Text;

            }
        }

            private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeServico.ForeColor = Color.FromArgb(70, 10, 45);
            lblValor.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataCad.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto01.BackColor = Color.FromArgb(70, 10, 45);
            lblFoto02.BackColor = Color.FromArgb(70, 10, 45);
            lblFoto03.BackColor = Color.FromArgb(70, 10, 45);
            lblFoto04.BackColor = Color.FromArgb(70, 10, 45);
            lblDescricao.ForeColor = Color.FromArgb(70, 10, 45);
            lblTexto.ForeColor = Color.FromArgb(70, 10, 45);
            lblTempoExecucao.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmpresa.ForeColor = Color.FromArgb(70, 10, 45);

            txtNomeServico.Clear();
            txtValor.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdData.Clear();
            pctImagem01.Image = Properties.Resources.semimagem;
            pctImagem02.Image = Properties.Resources.semimagem;
            pctImagem03.Image = Properties.Resources.semimagem;
            pctImagem04.Image = Properties.Resources.semimagem;
            txtDescricao.Clear();
            txtTexto.Clear();
            cmbTempo.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;

            txtNomeServico.Focus();
        }

        private void txtNomeServico_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 