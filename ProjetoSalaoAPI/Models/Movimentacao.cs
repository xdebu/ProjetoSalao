using ProjetoSalaoAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public ItemLanc ItemLanc { get; set; }
        public TipoMovim Tipo { get; set; }
        public DateTime DataMovim { get; set; }
        public Usuario UsuMovim { get; set; }

        public Movimentacao()
        {
        }

        public Movimentacao(int id, ItemLanc itemLanc, TipoMovim tipo, DateTime dataMovim, Usuario usuMovim)
        {
            Id = id;
            ItemLanc = itemLanc;
            Tipo = tipo;
            DataMovim = dataMovim;
            UsuMovim = usuMovim;
        }
    }
}
