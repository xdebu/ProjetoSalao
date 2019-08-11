using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models
{
    public class AgendaItem
    {
        public int Id { get; set; }
        public Agenda Agenda { get; set; }
        public ProdServ ProdServ { get; set; }

        public AgendaItem()
        {
        }

        public AgendaItem(int id, Agenda agenda, ProdServ prodServ)
        {
            Id = id;
            Agenda = agenda;
            ProdServ = prodServ;
        }
    }
}
