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

        public DbSet<ProjetoSalaoAPI.Models.Usuario> Usuario { get; set; }
    }
}
