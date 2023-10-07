using Microsoft.EntityFrameworkCore;
using Parcial2_BoteroAgudeloJessicaMaria.DAL.Entities;

namespace Parcial2_BoteroAgudeloJessicaMaria.DAL
{
    public class DataBaseContext : DbContext //Configurar la BD con Entity Framewor Core
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NaturalPerson>().HasIndex(c => c.FullName).IsUnique(); //Duplicidad del nombre
        }

        public DbSet<NaturalPerson> naturalPeople { get; set; }

    }
}
