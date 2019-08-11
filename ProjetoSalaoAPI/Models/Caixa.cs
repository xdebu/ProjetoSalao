using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public double Saldo { get; set; }
        public double ValorCred { get; set; }
        public double ValorDeb { get; set; }
        public Usuario UsuAbertura { get; set; }
        public DateTime DataAbertura { get; set; }
        public Usuario UsuFechamento { get; set; }
        public DateTime DataFechamento { get; set; }

        public Caixa()
        {
        }

        public Caixa(int id, double saldo, double valorCred, double valorDeb, Usuario usuAbertura, DateTime dataAbertura, Usuario usuFechamento, DateTime dataFechamento)
        {
            Id = id;
            Saldo = saldo;
            ValorCred = valorCred;
            ValorDeb = valorDeb;
            UsuAbertura = usuAbertura;
            DataAbertura = dataAbertura;
            UsuFechamento = usuFechamento;
            DataFechamento = dataFechamento;
        }
    }
}
