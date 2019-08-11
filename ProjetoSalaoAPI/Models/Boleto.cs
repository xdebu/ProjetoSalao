using System;
using System.Collections.Generic;

namespace ProjetoSalaoAPI.Models
{
    public class Boleto
    {
        public int Id { get; set; }
        public int CodBarra { get; set; }
        public int NrDocum { get; set; }
        public bool Alerta { get; set; }
        public double ValorTotal { get; set; }
        public Usuario UsuCad { get; set; }
        public DateTime DataCad { get; set; }
        public DateTime DatePagto { get; set; }
        public ICollection<BoletoVenc> BoletoVenc { get; set; } = new List<BoletoVenc>();

        public Boleto()
        {
        }

        public Boleto(int id, int codBarra, int nrDocum, bool alerta, double valorTotal, Usuario usuCad, DateTime dataCad, DateTime datePagto)
        {
            Id = id;
            CodBarra = codBarra;
            NrDocum = nrDocum;
            Alerta = alerta;
            ValorTotal = valorTotal;
            UsuCad = usuCad;
            DataCad = dataCad;
            DatePagto = datePagto;
        }
    }
}
