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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaCompleta`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a empresa.\n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaAtiva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaAtiva`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a empresa.\n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresacompleta` WHERE `NOME DA EMPRESA` LIKE '%" + Variaveis.nomeEmpresa + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a empresa.\n\n" + erro.Message);
            }
        }

        private void ExcluirEmpresa()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `empresa` WHERE `idEmpresa`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir a Empresa.\n\n" + erro.Message);
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked == true)
            {
                CarregarEmpresaAtiva();
            }
            else
            {
                CarregarEmpresa();
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);
            Variaveis.linhaSelecionada = -1;
            CarregarEmpresa();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadEmpresa().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadEmpresa().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha.");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                chkStatus.Enabled = true;
                CarregarEmpresa();
            }
            else
            {
                chkStatus.Checked = false;
                chkStatus.Enabled = false;
                Variaveis.nomeEmpresa = txtNome.Text;
                CarregarEmpresaNome();
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if(Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codEmpresa = Convert.ToInt32(dgvEmpresa[0, Variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvEmpresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmpresa.Sort(dgvEmpresa.Columns[1], ListSortDirection.Ascending);
            dgvEmpresa.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(Variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?","EXCLUIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    ExcluirEmpresa();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha.");
            }
        }
    }
}
