using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Lancamento
    {
        public int Id { get; set; }
        public Pessoas Funcionario { get; set; }
        public Pessoas Cliente { get; set; }
        public double ValorTotal { get; set; }
        public Usuario UsuCad { get; set; }
        public DateTime DataLanc { get; set; }
        public ICollection<ItemLanc> ItemLanc { get; set; } = new List<ItemLanc>();

        public Lancamento()
        {
        }

        public Lancamento(int id, Pessoas funcionario, Pessoas cliente, double valorTotal, Usuario usuCad, DateTime dataLanc)
        {
            Id = id;
            Funcionario = funcionario;
            Cliente = cliente;
            ValorTotal = valorTotal;
            UsuCad = usuCad;
            DataLanc = dataLanc;
        }

    }
}
