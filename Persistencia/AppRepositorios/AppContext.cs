using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;



namespace  Persistencia
{
    public class AppContext : DbContext

    {
        public DbSet<Migrantes> Migrantes {get; set;}
        public DbSet<Grupo> Grupo {get; set;}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Cenit")
            .EnableSensitiveDataLogging(true); 
        }

        
    }
}