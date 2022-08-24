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
    public partial class frmTelCliente : Form
    {
        public frmTelCliente()
        {
            InitializeComponent();
        }

        private void frmTelCliente_Load(object sender, EventArgs e)
        {
            pnlTelCliente.Location = new Point(this.Width / 2 - pnlTelCliente.Width / 2, this.Height / 2 - pnlTelCliente.Height / 2);

            CarregarClientes();
            cmbNomeCliente.Text = Variaveis.nomeCliente;

            if(Variaveis.funcao == "ALTERAR FONE")
            {
                CarregarDadosFoneCliente();
            }
        }

        private void InserirFoneCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonecliente`(`idFoneCliente`,`numeroFoneCliente`,`operFoneCliente`,`descFoneCliente`,`idCliente`) VALUES (DEFAULT,@numero,@operadora,@descricao,@codCliente)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.numeroCliente);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneCliente);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneCliente);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Telefone do cliente cadastrado com sucesso!", "CADASTRO DO TELEFONE DO CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Telefone do Cliente!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void AlterarFoneCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `fonecliente` SET `numeroFoneCliente`=@numero,`operFoneCliente`=@operadora,`descFoneCliente`=@descricao WHERE `idFoneCliente`=@codFone";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.numeroCliente);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneCliente);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneCliente);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Telefone do cliente alterado com sucesso!", "ALTERAÇÃO DO TELEFONE DO CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o Telefone do Cliente!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void CarregarClientes()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idCliente,nomeCliente FROM cliente ORDER BY nomeCliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbNomeCliente.DataSource = dt;
                cmbNomeCliente.DisplayMember = "nomeCliente";
                cmbNomeCliente.ValueMember = "idCliente";
                cmbNomeCliente.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a lista de clientes. \n\n" + erro.Message);
            }
        }

        private void CarregarDadosFoneCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT `idFoneCliente`, `numeroFoneCliente`, `operFoneCliente`, `descFoneCliente`, `nomeCliente` FROM `fonecliente` INNER JOIN `cliente` ON fonecliente.idCliente = cliente.idCliente WHERE idFoneCliente=@codFone";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneCliente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.numeroCliente = reader.GetString(1);
                    Variaveis.operFoneCliente = reader.GetString(2);
                    Variaveis.descFoneCliente = reader.GetString(3);
                    Variaveis.nomeCliente = reader.GetString(4);

                    txtCodigo.Text = Variaveis.codFoneCliente.ToString();
                    mkdTel.Text = Variaveis.numeroCliente;
                    cmbOperadora.Text = Variaveis.operFoneCliente;
                    txtDescricao.Text = Variaveis.descFoneCliente;
                    cmbNomeCliente.Text = Variaveis.nomeCliente;
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados do Telefone do Cliente!\n\n" + erro, "ERRO");
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadCliente().Show();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblNumeroTelefone.ForeColor = Color.FromArgb(70, 10, 45);
            lblOperadora.ForeColor = Color.FromArgb(70, 10, 45);
            lblDescrição.ForeColor = Color.FromArgb(70, 10, 45);


            if (cmbNomeCliente.Text == String.Empty)
            {
                lblNomeCliente.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a empresa");
                cmbNomeCliente.Focus();
            }
            else if (mkdTel.Text == String.Empty)
            {
                lblNumeroTelefone.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o número da empresa");
                mkdTel.Focus();
            }
            else if (cmbOperadora.Text == String.Empty)
            {
                lblOperadora.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a operadora");
                cmbOperadora.Focus();
            }
            else if (txtDescricao.Text == String.Empty)
            {
                lblDescrição.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a descrição");
                txtDescricao.Focus();
            }
            else
            {
                Variaveis.nomeCliente = cmbNomeCliente.Text;
                Variaveis.numeroCliente = mkdTel.Text;
                Variaveis.operFoneCliente = cmbOperadora.Text;
                Variaveis.descFoneCliente = txtDescricao.Text;

                if (Variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneCliente();
                }
                else if (Variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneCliente();
                }

                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
    }
}
