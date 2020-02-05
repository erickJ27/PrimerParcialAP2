using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAP2.DAL
{
    public class Contexto : DbContext
    {
        //public DbSet<Indefinidos> Indefinido { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-SBR4M50\SQLEXPRESS;Database=PrimerPacialDb;Trusted_Connection=true"));
        }
    }
}
