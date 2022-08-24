﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaKaique
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        //VALIDAÇÃO FTP
        private bool ValidarFTP()
        {
            if(string.IsNullOrEmpty(Variaveis.enderecoServidorFtp) ||
                string.IsNullOrEmpty(Variaveis.usuarioFtp) ||
                string.IsNullOrEmpty(Variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //CONVERTER A IMAGEM EM BYTE
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential
                (Variaveis.usuarioFtp, Variaveis.senhaFtp);
            byte[] imageToByte = ftpClient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        //CONVERTER A IMAGEM DE BYTE PARA IMG
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `cliente`(`idCliente`,`nomeCliente`,`emailCliente`,`senhaCliente`,`statusCliente`,`dataCadCliente`,`fotoCliente`) VALUES (DEFAULT,@nome,@email,@senha,@status,@dataCad,@foto)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!", "CADASTRO DO CLIENTE");
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);
                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCliente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada", "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o cliente!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void AlterarCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nome,`emailCliente`=@email,`senhaCliente`=@senha,`statusCliente`=@status WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue(@"nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue(@"email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue(@"senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue(@"status", Variaveis.statusCliente);
                cmd.Parameters.AddWithValue(@"codigo", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso!", "ALTERAÇÃO DO CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o cliente!\n\n" + erro.Message, "ERRO!");
            }
        }

        private void AlterarFotoCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `cliente` SET `fotoCliente`=@foto WHERE `idCliente`=codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoCliente);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codCliente);
                cmd.ExecuteNonQuery();
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(Variaveis.fotoCliente);
                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoCliente, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Foto não selecionada\n\n" + erro.Message, "Foto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o cliente!\n\n" + erro.Message, "ERRO!");
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
                string selecionar = "SELECT * FROM 'fonecliente' WHERE idCliente=@codigo";
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
        }
        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);

            Variaveis.linhaFoneSelecionada = -1;

            if(Variaveis.funcao == "ALTERAR")
            {
                lblCadCliente.Text = "ALTERAÇÃO DO CLIENTE";
                pnlTelefoneCliente.Enabled = true;
                CarregarDadosCliente();
                CarregarFoneCliente();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR FONE";
            new frmTelCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(Variaveis.linhaFoneSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR FONE";
                new frmTelCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaFoneSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes){ 
                    ExcluirFoneCliente();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);

            if (txtNomeCliente.Text == String.Empty)
            {
                lblNomeCliente.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNomeCliente.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o e-mail do cliente");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status");
            }
            else if (Variaveis.atFotoCliente != "S")
            {
                lblFoto.BackColor= Color.Red;
                MessageBox.Show("Favor selecionar uma foto");
            }
            else
            {
                Variaveis.nomeCliente = txtNomeCliente.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.statusCliente = cmbStatus.Text;
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Variaveis.dataCadCliente = DateTime.Parse(mkdData.Text);
                //Variaveis.fotoCliente = "cliente/" + nomeFoto;

                if(Variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                    CarregarClienteCadastrado();
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                    if(Variaveis.atFotoCliente == "S")
                    {
                        AlterarFotoCliente();
                    }
                }

                pnlTelefoneCliente.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckFileExists = true; // Verifica se o caminho existe
                ofdFoto.CheckPathExists = true; // Verifica se o arquivo existe
                ofdFoto.RestoreDirectory = true; // Restaura ao diretorio inicial

                DialogResult dr = ofdFoto.ShowDialog();
                pctPerfil.Image = Image.FromFile(ofdFoto.FileName);
                Variaveis.fotoCliente = "cliente/" + Path.GetFileName(ofdFoto.FileName); // A variavel recebe o nome da foto com o nome da pasta "cliente/nome_foto.png"

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Variaveis.atFotoCliente = "S";
                        Variaveis.caminhoFotoCliente = ofdFoto.FileName;
                    }
                    catch (SecurityException erro)
                    {
                        MessageBox.Show("Erro de segurança - Fale com o Admin. \n Mensagem: " + erro.Message + "\nDetalhe: \n" + erro.StackTrace);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Você não tem permissão. \nDetalhe: " + erro.Message);
                    }
                }
                btnSalvar.Focus();
            }
            catch
            {
                btnSalvar.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                btnPerfil.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNomeCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblEmail.ForeColor = Color.FromArgb(70, 10, 45);
            lblSenha.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFoto.BackColor = Color.FromArgb(70, 10, 45);

            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdData.Clear();
            pctPerfil.Image = Properties.Resources.semimagem;

            txtNomeCliente.Focus();
        }

        private void pnlTelefoneCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTelefoneCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTelefoneCliente.Sort(dgvTelefoneCliente.Columns[1], ListSortDirection.Ascending);
            dgvTelefoneCliente.ClearSelection();
        }

        private void dgvTelefoneCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaFoneSelecionada = int.Parse(e.RowIndex.ToString());

            if (Variaveis.linhaFoneSelecionada >= 0)
            {
                Variaveis.codFoneCliente = Convert.ToInt32(dgvTelefoneCliente[0, Variaveis.linhaFoneSelecionada].Value);
            }
        }
    }
}
