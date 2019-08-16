using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Telefone { get; set; }
        public Pessoas Pessoa { get; set; }

        public Contato()
        {
        }

        public Contato(int id, string descricao, int telefone, Pessoas pessoa)
        {
            Id = id;
            Descricao = descricao;
            Telefone = telefone;
            Pessoa = pessoa;
        }
    }
}
