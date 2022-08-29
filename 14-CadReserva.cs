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
    public partial class frmCadReserva : Form
    {

        string anoI, mesI, diaI, anoF, mesF, diaF;

        public frmCadReserva()
        {
            InitializeComponent();
        }

        private void InserirReserva()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `reserva`(`idReserva`,`obsReserva`,`dataReserva`,`horaReserva`,`statusReserva`,`idFuncionario`,`idCliente`,`idServico`) VALUES (DEFAULT,@obs,@dataReserva,@horaReserva,@status,@codFuncionario,@codCliente,@codServico)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva cadastrada com sucesso!", "CADASTRO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar a reserva! \n\n" + erro.Message, "ERRO!");
            }
        }

        private void AlterarReserva()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `reserva` SET `obsReserva`=@obs,`dataReserva`=@dataReserva,`horaReserva`=@horaReserva,`statusReserva`=@status,`idFuncionario`=codFuncionario,`idCliente`=@codCliente,`idServico`=@codServico WHERE `idReserva`=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", Variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", Variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", Variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", Variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", Variaveis.codServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva alterada com sucesso!", "ALTERAÇÃO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar a reserva! \n\n" + erro.Message, "ERRO!");
            }
        }

        private void CarregarDadosReserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT `idReserva`,`obsReserva`,`dataReserva`,`horaReserva`,`statusReserva`,`nomeFuncionario`,`nomeCliente`,`nomeServico` FROM `reserva` INNER JOIN `funcionario` ON `reserva`.`idFuncionario` = `funcionario`.`idFuncionario` INNER JOIN `cliente` ON `reserva`.`idCliente` = `cliente`.`idCliente` INNER JOIN `servico` ON `reserva`.`idServico` = `servico`.`idServico` WHERE `idReserva` = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codReserva);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Variaveis.obsReserva = reader.GetString(1);
                    Variaveis.dataReserva = reader.GetDateTime(2);
                    Variaveis.horarioReserva = DateTime.Parse(reader.GetString(3));
                    Variaveis.statusReserva = reader.GetString(4);
                    Variaveis.nomeFuncionario = reader.GetString(5);
                    Variaveis.nomeCliente = reader.GetString(6);
                    Variaveis.nomeServico = reader.GetString(7);

                    txtCodigo.Text = Variaveis.codReserva.ToString();
                    txtObs.Text = Variaveis.obsReserva;
                    mkdData.Text = Variaveis.dataReserva.ToString();
                    cmbHorarioReserva.Text = Variaveis.horarioReserva.ToString("HH:mm");
                    cmbStatus.Text = Variaveis.statusReserva;
                    cmbFuncionario.Text = Variaveis.nomeFuncionario;
                    cmbCliente.Text = Variaveis.nomeCliente;
                    cmbServico.Text = Variaveis.nomeServico;
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados da reserva! \n\n" + erro.Message, "ERRO!");
            }
        }

        private void frmCalReserva_Load(object sender, EventArgs e)
        {
            pnlCalReserva.Location = new Point(this.Width / 2 - pnlCalReserva.Width / 2, this.Height / 2 - pnlCalReserva.Height / 2);
        }

        private void calReserva_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbHorarioReserva.Focus();
            }
        }

        private void cmbHorarioReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbFuncionario.Focus();
            }
        }

        private void cmbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCliente.Focus();
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbServico.Focus();
            }
        }

        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calReserva.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtObs.Text == String.Empty)
            {
                lblObs.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher a observação da reserva");
                txtObs.Focus();
            }
            else if (cmbHorarioReserva.Text == String.Empty)
            {
                lblHorarioReserva.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o horario da reserva");
                cmbHorarioReserva.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o status da reserva");
                cmbStatus.Focus();
            }
            else if (cmbFuncionario.Text == String.Empty)
            {
                lblFuncionario.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o funcionario");
            }
            else if (cmbCliente.Text == String.Empty)
            {
                lblCliente.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o cliente");
            }
            else if (cmbServico.Text == String.Empty)
            {
                lblServico.ForeColor = Color.Red;
                MessageBox.Show("Favor preencher o serviço escolhido");
            }
            else
            {
                Variaveis.obsReserva = txtObs.Text;
                //Variaveis.horarioReserva = cmbHorarioReserva.Text;
                Variaveis.statusReserva = cmbStatus.Text;

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblObs.ForeColor = Color.FromArgb(70, 10, 45);
            lblHorarioReserva.ForeColor = Color.FromArgb(70, 10, 45);
            lblStatus.ForeColor = Color.FromArgb(70, 10, 45);
            lblFuncionario.ForeColor = Color.FromArgb(70, 10, 45);
            lblCliente.ForeColor = Color.FromArgb(70, 10, 45);
            lblServico.ForeColor = Color.FromArgb(70, 10, 45);
            lblDataReserva.ForeColor = Color.FromArgb(70, 10, 45);

            txtObs.Clear();
            cmbHorarioReserva.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;

            txtObs.Focus();
        }
    }
}
