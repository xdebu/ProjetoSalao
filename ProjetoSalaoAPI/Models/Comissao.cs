using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Comissao
    {
        public int Id { get; set; }
        public Pessoas Funcionario { get; set; }
        public double TxComissao { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataFim { get; set; }
        public Usuario UsuCad { get; set; }
        public DateTime DataCad { get; set; }

        public Comissao()
        {
        }

        public Comissao(int id, Pessoas funcionario, double txComissao, DateTime dataIni, DateTime dataFim, Usuario usuCad, DateTime dataCad)
        {
            Id = id;
            Funcionario = funcionario;
            TxComissao = txComissao;
            DataIni = dataIni;
            DataFim = dataFim;
            UsuCad = usuCad;
            DataCad = dataCad;
        }
    }
}
