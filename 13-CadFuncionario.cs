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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblNivel.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorarioTrabalho.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmpresa.ForeColor = Color.FromArgb(70, 10, 45);

            if (txtNomeFuncionario.Text == String.Empty)
            {
                lblNomeFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o nome do funcionario");
                txtNomeFuncionario.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o e-mail do funcionario");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (cmbNivel.Text == String.Empty)
            {
                lblNivel.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o nivel");
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status");
            }
            else if (cmbHorarioTrabalho.Text == String.Empty)
            {
                lblHorarioTrabalho.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o Horario de trabalho");
            }
            else if (cmbEmpresa.Text == String.Empty)
            {
                lblEmpresa.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a empresa");
            }
            else
            {
                Variaveis.nomeFuncionario = txtNomeFuncionario.Text;
                Variaveis.emailFuncionario = txtEmail.Text;
                Variaveis.senhaFuncionario = txtSenha.Text;
                Variaveis.nivelFuncionario = cmbNivel.Text;
                Variaveis.statusFuncionario = cmbStatus.Text;
                Variaveis.horarioFuncionario = DateTime.Parse(cmbHorarioTrabalho.Text);
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadFuncionario = DateTime.Parse(mkdData.Text);

                pnlTelefoneFuncionario.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblNivel.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorarioTrabalho.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmpresa.ForeColor = Color.FromArgb(70, 10, 45);

            txtNomeFuncionario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbNivel.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            mkdData.Clear();
            cmbHorarioTrabalho.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;

            txtNomeFuncionario.Focus();
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbNivel.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cmbHorarioTrabalho.Focus();
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbHorarioTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbEmpresa.Focus();
            }
        }

        private void pnlTelefoneFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
