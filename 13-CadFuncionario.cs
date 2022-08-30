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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void InserirFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `funcionario`(`idFuncionario`,`nomeFuncionario`,`emailFuncionario`,`senhaFuncionario`,`nivelFuncionario`,`statusFuncionario`,`dataCadFuncionario`,`horarioTrabFuncionario`,`idEmpresa`) VALUES (DEFAULT,@nome,@email,@senha,@nivel,@status,@dataCad,@horario,@empresa)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@nivel", Variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadFuncionario.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horario", Variaveis.horarioFuncionario.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@empresa", Variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastrado com sucesso!", "CADASTRO DO FUNCIONARIO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Funcionario!\n\n" + erro.Message, "ERRO!");
            }
        }

        /*private void AlterarFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE cliente SET nomeCliente=@nome,emailCliente=@email,senhaCliente=@senha,statusCliente=@status WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso!", "Alteração do cliente");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar cliente\n\n" + ex, "ERRO");
            }
        }

        private void CarregarDadosCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM cliente WHERE idCliente=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.nomeCliente = reader.GetString(1);
                    Variaveis.emailCliente = reader.GetString(2);
                    Variaveis.senhaCliente = reader.GetString(3);
                    Variaveis.statusCliente = reader.GetString(4);
                    Variaveis.dataCadCliente = DateTime.Parse(reader.GetString(5));
                    Variaveis.fotoCliente = reader.GetString(6);
                    Variaveis.fotoCliente = Variaveis.fotoCliente.Remove(0, 8);
                    txtCodigo.Text = Variaveis.codCliente.ToString();
                    txtNomeCliente.Text = Variaveis.nomeCliente;
                    txtEmail.Text = Variaveis.emailCliente;
                    txtSenha.Text = Variaveis.senhaCliente;
                    cmbStatus.Text = Variaveis.statusCliente;
                    mkdData.Text = Variaveis.dataCadCliente.ToString("dd/MM/yyyy");
                    pctPerfil.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "cliente/" + Variaveis.fotoCliente));
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados do cliente! \n\n" + erro, "ERRO");
            }
        }

        private void CarregarClienteCadastrado()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idCliente FROM cliente WHERE nomeCliente=@nome AND emailcliente=@email";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { }
                Variaveis.codCliente = reader.GetInt32(0);
                txtCodigo.Text = Variaveis.codCliente.ToString();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar cliente cadastrado! \n\n" + erro.Message, "ERRO");
            }
        }

        private void CarregarFoneCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `fonecliente` WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTelefoneCliente.DataSource = dt;
                dgvTelefoneCliente.Columns[0].HeaderText = "CÓDIGO";
                dgvTelefoneCliente.Columns[0].Visible = false;
                dgvTelefoneCliente.Columns[1].HeaderText = "NÚMERO TELEFONE";
                dgvTelefoneCliente.Columns[2].HeaderText = "OPERADORA";
                dgvTelefoneCliente.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvTelefoneCliente.Columns[4].HeaderText = "CLIENTE";
                dgvTelefoneCliente.Columns[4].Visible = false;
                dgvTelefoneCliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o telefone do Cliente. \n\n" + erro.Message);
            }
        }

        private void ExcluirFoneCliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM 'Fonecliente` WHERE `idFoneCliente =@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTelefoneCliente.DataSource = dt;
                dgvTelefoneCliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o Telefone do Cliente. \n\n" + erro.Message);
            }
        }*/

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlCadFuncionario.Location = new Point(this.Width / 2 - pnlCadFuncionario.Width / 2, this.Height / 2 - pnlCadFuncionario.Height / 2);

            Variaveis.linhaFoneSelecionada = -1;
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
