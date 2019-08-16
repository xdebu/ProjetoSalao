using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public Pessoas Pessoas { get; set; }
        public DateTime DataReserva { get; set; }
        public Pessoas Funcionario { get; set; }
        public Usuario UsuCad { get; set; }
        public DateTime DataCad { get; set; }
        public ICollection<AgendaItem> AgendaItem { get; set; } = new List<AgendaItem>();

        public Agenda()
        {
        }

        public Agenda(int id, Pessoas pessoas, DateTime dataReserva, Pessoas funcionario, Usuario usuCad, DateTime dataCad)
        {
            Id = id;
            Pessoas = pessoas;
            DataReserva = dataReserva;
            Funcionario = funcionario;
            UsuCad = usuCad;
            DataCad = dataCad;
        }
    }
}
