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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }
        
        private void CarregarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientecompleto`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Conectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente. \n\n" + erro.Message);
            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Conectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente. \n\n" + erro.Message);
            }
        }

        private void CarregarClienteNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientecompleto` WHERE `NOME CLIENTE` LIKE '%" + Variaveis.nomeCliente + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente. \n\n" + erro.Message);
            }
        }

        private void ExcluirCliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `cliente` WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao escluir o Cliente. \n\n" + erro.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            pnlCliente.Location = new Point(this.Width / 2 - pnlCliente.Width / 2, this.Height / 2 - pnlCliente.Height / 2);

            Variaveis.linhaSelecionada = -1;
            CarregarCliente();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha.");
            }

        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(chkStatus.Checked == true)
            {
                CarregarClienteAtivo();
            }
            else
            {
                CarregarCliente();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                chkStatus.Enabled = true;
                CarregarCliente();
            }
            else
            {
                chkStatus.Checked = false;
                chkStatus.Enabled = false;
                Variaveis.nomeCliente = txtNome.Text;
                CarregarClienteNome();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(Variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    ExcluirCliente();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codCliente = Convert.ToInt32(dgvCliente[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending);
            dgvCliente.ClearSelection();
        }
    }
}
