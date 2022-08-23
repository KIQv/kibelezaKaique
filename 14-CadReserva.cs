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
    public partial class frmCadReserva : Form
    {
        public frmCadReserva()
        {
            InitializeComponent();
        }

        private void frmCalReserva_Load(object sender, EventArgs e)
        {
            pnlCalReserva.Location = new Point(this.Width / 2 - pnlCalReserva.Width / 2, this.Height / 2 - pnlCalReserva.Height / 2);
        }

        private void calReserva_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbHorarioReserva.Focus();
            }
        }

        private void cmbHorarioReserva_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbFuncionario.Focus();
            }
        }

        private void cmbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCliente.Focus();
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbServico.Focus();
            }
        }

        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calReserva.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtObs.Text == String.Empty)
            {
                lblObs.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a observação da reserva");
                txtObs.Focus();
            }
            else if (cmbHorarioReserva.Text == String.Empty)
            {
                lblHorarioReserva.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o horario da reserva");
                cmbHorarioReserva.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status da reserva");
                cmbStatus.Focus();
            }
            else if (cmbFuncionario.Text == String.Empty)
            {
                lblFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o funcionario");
            }
            else if (cmbCliente.Text == String.Empty)
            {
                lblCliente.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o cliente");
            }
            else if (cmbServico.Text == String.Empty)
            {
                lblServico.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o serviço escolhido");
            }
            else
            {
                Variaveis.obsReserva = txtObs.Text;
                Variaveis.horarioReserva = cmbHorarioReserva.Text;
                Variaveis.statusReserva = cmbStatus.Text;
                Variaveis.funcionarioReserva = cmbFuncionario.Text;
                Variaveis.clienteReserva = cmbCliente.Text;
                Variaveis.servicoReserva = cmbServico.Text;

                //mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //Variaveis.dataCadFuncionario = DateTime.Parse(mkdData.Text);

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblObs.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorarioReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);

            txtObs.Clear();
            cmbHorarioReserva.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;

            txtObs.Focus();
        }
    }
}
