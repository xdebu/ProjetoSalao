using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class ItemLanc
    {
        public int Id { get; set; }
        public ProdServ ProdServ { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public Lancamento Lancamento { get; set; }
        
        public ItemLanc()
        {
        }

        public ItemLanc(int id, ProdServ prodServ, double valor, double quantidade, Lancamento lancamento)
        {
            Id = id;
            ProdServ = prodServ;
            Valor = valor;
            Quantidade = quantidade;
            Lancamento = lancamento;
        }
    }
}
