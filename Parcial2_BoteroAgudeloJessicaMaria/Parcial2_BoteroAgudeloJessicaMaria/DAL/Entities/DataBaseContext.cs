using Microsoft.EntityFrameworkCore;
using Parcial2_BoteroAgudeloJessicaMaria.DAL.Entities;

namespace Parcial2_BoteroAgudeloJessicaMaria.DAL
{
    public class DataBaseContext : DbContext //Configurar la BD con Entity Framewor Core
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        public DbSet<NaturalPerson> naturalPeople { get; set; }

    }
}
