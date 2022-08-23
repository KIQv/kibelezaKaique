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
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            pnlEmail.Location = new Point(this.Width / 2 - pnlEmail.Width / 2, this.Height / 2 - pnlEmail.Height / 2);
        }
    }
}
