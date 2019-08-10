using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class ProdServ
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public double ValorUnit { get; set; }
        public double QtdeEstoque { get; set; }
        public Usuario UsuCad { get; set; }

        public ProdServ()
        {
        }

        public ProdServ(int id, string descricao, string tipo, double valorUnit, double qtdeEstoque, Usuario usuCad)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
            ValorUnit = valorUnit;
            QtdeEstoque = qtdeEstoque;
            UsuCad = usuCad;
        }
    }
}
