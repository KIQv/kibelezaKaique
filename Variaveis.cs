using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kibelezaKaique
{
    public static class Variaveis
    {
        //Geral
        public static string funcao;
        public static int linhaSelecionada, linhaFoneSelecionada;

        //Login
        public static string usuario, senha, nivel;

        //Empresa 
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpf, razaoSocial, emailEmpresa, statusEmpresa;
        public static DateTime dataCadEmpresa, horarioAtendEmpresa;

        //Cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente;
        public static DateTime dataCadCliente;

        //Funcionario
        public static int codFuncionario;
        public static string nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, statusFuncionario;
        public static DateTime dataCadFuncionario, horarioFuncionario;

        //Reserva
        public static int codReserva;
        public static string obsReserva, statusReserva;
        public static DateTime dataReserva, horarioReserva;

        //Serviço
        public static int codServico;
        public static string nomeServico, valorServico, statusServico, fotoServico1, fotoServico2, fotoServico3, fotoServico4, descServico, textoServico, tempoExecServico, empresaServico, atFotoServico;
        public static DateTime dataCadServico;

        //FoneEmpresa
        public static int codFoneEmpresa;
        public static string numeroEmpresa, operFoneEmpresa, descFoneEmpresa;

        //FoneCliente
        public static int codFoneCliente;
        public static string numeroCliente, operFoneCliente, descFoneCliente;

        //FoneFuncionario
        public static int codFoneFuncionario;
        public static string numeroFuncionario, operFuncionario, descFoneFuncionario;
    }
}
