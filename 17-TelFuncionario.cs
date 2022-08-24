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
    public partial class frmTelFuncionario : Form
    {
        public frmTelFuncionario()
        {
            InitializeComponent();
        }

        private void frmTelFuncionario_Load(object sender, EventArgs e)
        {
            pnlTelFuncionario.Location = new Point(this.Width / 2 - pnlTelFuncionario.Width / 2, this.Height / 2 - pnlTelFuncionario.Height / 2);

            CarregarFuncionarios();
            cmbNomeFuncionario.Text = Variaveis.nomeFuncionario;

            if (Variaveis.funcao == "ALTERAR FONE")
            {
                CarregarDadosFoneFuncionario();
            }
        }

        private void InserirFoneFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonefuncionario`(`idFoneFuncionario`,`numeroFoneFuncionario`,`operFoneFuncionario`,`descFoneFuncionario`,`idFuncionario`) VALUES (DEFAULT,@numero,@operadora,@descricao,@codFuncionario)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.numeroFuncionario);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneFuncionario);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneFuncionario);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Telefone do funcionario cadastrado com sucesso!", "CADASTRO DO TELEFONE DO FUNCIONARIO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Telefone do Funcionario!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void AlterarFoneFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `fonefuncionario` SET `numeroFoneFuncionario`=@numero,`operFoneFuncionario`=@operadora,`descFoneFuncionario`=@descricao WHERE `idFoneFuncionario`=@codFone";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numero", Variaveis.numeroFuncionario);
                cmd.Parameters.AddWithValue("@operadora", Variaveis.operFoneFuncionario);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descFoneFuncionario);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Telefone do funcionario alterado com sucesso!", "ALTERAÇÃO DO TELEFONE DO FUNCIONARIO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o Telefone do Funcionario!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idFuncionario,nomeFuncionario FROM funcionario ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbNomeFuncionario.DataSource = dt;
                cmbNomeFuncionario.DisplayMember = "nomeFuncionario";
                cmbNomeFuncionario.ValueMember = "idFuncionario";
                cmbNomeFuncionario.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a lista de funcionarios. \n\n" + erro.Message);
            }
        }

        private void CarregarDadosFoneFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT `idFoneFuncionario`, `numeroFoneFuncionario`, `operFoneFuncionario`, `descFoneFuncionario`, `nomeFuncionario` FROM `fonefuncionario` INNER JOIN `funcionarios` ON fonefuncionario.idFuncionario = funcionario.idFuncionario WHERE idFoneFuncionario=@codFone";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", Variaveis.codFoneFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.numeroFuncionario = reader.GetString(1);
                    Variaveis.operFoneFuncionario = reader.GetString(2);
                    Variaveis.descFoneFuncionario = reader.GetString(3);
                    Variaveis.nomeFuncionario = reader.GetString(4);

                    txtCodigo.Text = Variaveis.codFoneFuncionario.ToString();
                    mkdTel.Text = Variaveis.numeroFuncionario;
                    cmbOperadora.Text = Variaveis.operFoneFuncionario;
                    txtDescricao.Text = Variaveis.descFoneFuncionario;
                    cmbNomeFuncionario.Text = Variaveis.nomeFuncionario;
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados do Telefone do Funcionario!\n\n" + erro, "ERRO");
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmCadFuncionario().Show();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblNumeroTelefone.ForeColor = Color.FromArgb(70, 10, 45);
            lblOperadora.ForeColor = Color.FromArgb(70, 10, 45);
            lblDescrição.ForeColor = Color.FromArgb(70, 10, 45);


            if (cmbNomeFuncionario.Text == String.Empty)
            {
                lblNomeFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a empresa");
                cmbNomeFuncionario.Focus();
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
                Variaveis.nomeFuncionario = cmbNomeFuncionario.Text;
                Variaveis.numeroFuncionario = mkdTel.Text;
                Variaveis.operFoneFuncionario = cmbOperadora.Text;
                Variaveis.descFoneFuncionario = txtDescricao.Text;

                if (Variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneFuncionario();
                }
                else if (Variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneFuncionario();
                }

                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
    }
}
