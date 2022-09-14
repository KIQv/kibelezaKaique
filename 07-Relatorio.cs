using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaKaique
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            pnlRelatorio.Location = new Point(this.Width / 2 - pnlRelatorio.Width / 2, this.Height / 2 - pnlRelatorio.Height / 2);
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarClienteInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteinativo` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarClienteTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarFuncionarioAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarFuncionarioInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarFuncionarioTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariotelefone` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarEmpresaAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarEmpresaInativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresainativa` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }
        private void CarregarEmpresaTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresatelefone` ";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a empresa \n\n" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked == true)
            {
                if (radAtivo.Checked == true)
                {
                    CarregarClienteAtivo();
                }
                else if (radInativo.Checked == true)
                {
                    CarregarClienteInativo();
                }
                else if (radTelefone.Checked == true)
                {
                    CarregarClienteTelefone();
                }
                else
                {
                    MessageBox.Show("Selecione um filtro!");
                }
            }
            else if (radFuncionario.Checked == true)
            {
                if (radAtivo.Checked == true)
                {
                    CarregarFuncionarioAtivo();
                }
                else if (radInativo.Checked == true)
                {
                    CarregarFuncionarioInativo();
                }
                else if (radTelefone.Checked == true)
                {
                    CarregarFuncionarioTelefone();
                }
                else
                {
                    MessageBox.Show("Selecione um filtro!");
                }
            }
            else if (radEmpresa.Checked == true)
            {
                if (radAtivo.Checked == true)
                {
                    CarregarEmpresaAtivo();
                }
                else if (radInativo.Checked == true)
                {
                    CarregarEmpresaInativa();
                }
                else if (radTelefone.Checked == true)
                {
                    CarregarEmpresaTelefone();
                }
                else
                {
                    MessageBox.Show("Selecione um filtro!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             if (dgvRelatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog(); // Caixa de salvamento
                salvar.Filter = "PDF (*.pdf)|*.pdf"; // Filtro em PDF
                salvar.FileName = "Nome do arquivo.pdf"; // Nome do arquivo
                bool fileError = false; // Erro de arquivo inicia em falso
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName); // Deleta arquivo existente
                        }
                        catch (IOException erro)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possível gerar os dados no disco." + erro.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvRelatorio.Columns.Count); // Gerar tabela em PDF
                            pdfTable.DefaultCell.Padding = 3; // Margin interna na célula de 3px
                            pdfTable.WidthPercentage = 100; // Largura de 100%
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // Alinhamento a esquerda

                            foreach (DataGridViewColumn column in dgvRelatorio.Columns) // Gerar os títulos
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvRelatorio.Rows) // Inserir os valores
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f); // Estrutura
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dados exportados com sucesso !!!", "Info");
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro :" + erro.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Exportação não salva !!!", "Info");
            }
        }
    }
}
