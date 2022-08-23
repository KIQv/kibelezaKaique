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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            if(Variaveis.funcao == "ALTERAR")
            {
                lblCadCliente.Text = "ALTERAÇÃO DO CLIENTE";
                pnlTelefoneCliente.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "EXCLUIR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);

            if (txtNomeCliente.Text == String.Empty)
            {
                lblNomeCliente.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNomeCliente.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o e-mail do cliente");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status");
            }
            else if (Variaveis.atFotoCliente != "S")
            {
                lblFoto.BackColor= Color.Red;
                MessageBox.Show("Favor selecionar uma foto");
            }
            else
            {
                Variaveis.nomeCliente = txtNomeCliente.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.statusCliente = cmbStatus.Text;
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadCliente = DateTime.Parse(mkdData.Text);
                //Variaveis.fotoCliente = "cliente/" + nomeFoto;

                pnlTelefoneCliente.Enabled = true;
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Variaveis.atFotoCliente = "S";
            btnSalvar.Focus();
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                btnPerfil.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);

            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdData.Clear();
            pctPerfil.Image = Properties.Resources.semimagem;

            txtNomeCliente.Focus();
        }

        private void pnlTelefoneCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
