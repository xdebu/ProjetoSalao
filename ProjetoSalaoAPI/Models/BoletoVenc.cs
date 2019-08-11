using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class BoletoVenc
    {
        public int Id { get; set; }
        public int NrParcela { get; set; }
        public DateTime DataVencto { get; set; }
        public double ValorParcela { get; set; }

        public BoletoVenc()
        {
        }

        public BoletoVenc(int id, int nrParcela, DateTime dataVencto, double valorParcela)
        {
            Id = id;
            NrParcela = nrParcela;
            DataVencto = dataVencto;
            ValorParcela = valorParcela;
        }
    }
}
