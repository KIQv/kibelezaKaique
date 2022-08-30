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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Centralizar o painel
            //pnlLogin.Location = new Point(200, 100)
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width/2, this.Height/2 - pnlLogin.Height/2);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Variaveis.usuario = txtEmail.Text;
            Variaveis.senha = txtSenha.Text;

            if(Variaveis.usuario == "Kaique" && Variaveis.senha == "123")
            {
                Variaveis.nivel = "ADMINISTRADOR";
                new frmMenu().Show();
                Hide();
            }
            else
            {
                try
                {
                    banco.Conectar();
                    string selecionar = "SELECT `nomeFuncionario`,`emailFuncionario`,`senhaFuncionario`,`nivelFuncionario` FROM `funcionario` WHERE `emailFuncionario`=@email AND `senhaFuncionario`=@senha AND `statusFuncionario`=@status";
                    MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                    cmd.Parameters.AddWithValue("@email", Variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Variaveis.usuario = reader.GetString(0);
                        Variaveis.nivel = reader.GetString(3);
                        new frmMenu().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO AO ACESSAR O BANCO DE DADOS");
                }
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
                btnEntrar.PerformClick();
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }
    }
}
