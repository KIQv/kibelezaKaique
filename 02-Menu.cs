using MySql.Data.MySqlClient;
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

        private void CarregarReserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservacompleta` WHERE `CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%' AND `FUNCIONARIO` LIKE '%" + Variaveis.nomeFuncionario + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;

                dgvMenu.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a reserva \n\n" + erro.Message);
            }
        }

        private void CarregarReservaStatus()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservacompleta` WHERE `STATUS` =@status AND `CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%' AND `FUNCIONARIO` LIKE '%" + Variaveis.nomeFuncionario + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;

                dgvMenu.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a reserva \n\n" + erro.Message);
            }
        }

        private void AlterarStatus()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `reserva` SET `statusReserva`=@status WHERE `idReserva`=codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("codigo", Variaveis.codReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource=dt;
                dgvMenu.ClearSelection();

                MessageBox.Show("A reserva " + Variaveis.codReserva + " foi alterada para " +Variaveis.statusReserva);

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar o status da reserva. \n\n" + erro.Message);
            }
        }

        private void Atribuir()
        {
            Variaveis.statusReserva = cmbStatus.Text;
            Variaveis.nomeCliente = txtCliente.Text;
            Variaveis.nomeFuncionario = txtFuncionario.Text;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - pnlMenu.Width / 2, this.Height / 2 - pnlMenu.Height / 2);

            lblUsuario.Text = Variaveis.usuario + " Bem vindo ao sistema KiBeleza!";

            cmbStatus.SelectedIndex = -1;

            Variaveis.linhaSelecionada = -1;

            CarregarReserva();

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
            Variaveis.funcao = "AGENDAR";
            new frmCadReserva().Show();
            Hide();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codReserva = Convert.ToInt32(dgvMenu[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvMenu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvMenu.Sort(dgvMenu.Columns[1], ListSortDirection.Ascending);
            dgvMenu.ClearSelection();
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked == true)
            {
                txtCliente.Enabled = true;
            }
            else
            {
                txtCliente.Clear();
                txtCliente.Enabled = false;
            }
        }

        private void chkFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFuncionario.Checked == true)
            {
                txtFuncionario.Enabled = true;
            }
            else
            {
                txtFuncionario.Clear();
                txtFuncionario.Enabled = false;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Atribuir();
            if(Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            Variaveis.statusReserva = "APROVADA";
            AlterarStatus();
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Variaveis.statusReserva = "CANCELADA";
            AlterarStatus();
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Variaveis.statusReserva = "FINALIZADA";
            AlterarStatus();
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnAguardar_Click(object sender, EventArgs e)
        {
            Variaveis.statusReserva = "AGUARDANDO";
            AlterarStatus();
            Atribuir();
            if (Variaveis.statusReserva == "TODAS")
            {
                CarregarReserva();
            }
            else
            {
                CarregarReservaStatus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "EDITAR";
                new frmCadReserva().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha.");
            }
        }
    }
}
