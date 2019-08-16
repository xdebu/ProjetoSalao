using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSalaoAPI.Models
{
    public class ProjetoSalaoAPIContext : DbContext
    {
        public ProjetoSalaoAPIContext (DbContextOptions<ProjetoSalaoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ProdServ> ProdServ { get; set; }
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<AgendaItem> AgendaItem { get; set; }
        public DbSet<Boleto> Boleto { get; set; }
        public DbSet<BoletoVenc> BoletoVenc { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<ItemLanc> ItemLanc { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        public DbSet<Comissao> Comissao { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Contato> Contato { get; set; }
    }
}
