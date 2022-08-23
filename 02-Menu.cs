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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);

            lblUsuario.Text = Variaveis.usuario + " Bem vindo ao sistema KiBeleza!";

            timer1.Start();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar?", "ENCERRAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(resposta == DialogResult.No)
            {
                new frmLogin().Show();
                Close();
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void pctRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().Show();
            Hide();
        }

        private void pctContato_Click(object sender, EventArgs e)
        {
            new frmContato().Show();
            Hide();
        }

        private void pctEmail_Click(object sender, EventArgs e)
        {
            new frmEmail().Show();
            Hide();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Hide();
        }

        private void pctServico_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            new frmCadReserva().Show();
            Hide();
        }
    }
}
