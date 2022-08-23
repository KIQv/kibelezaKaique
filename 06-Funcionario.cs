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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadFuncionario().Show();
            Hide();
        }
    }
}
