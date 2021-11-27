using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio;

namespace Hackaton.App.Persistencia
{
<<<<<<< HEAD
    public class AppContext: DbContext{
        public DbSet<uSistemas> uSistemas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
=======
    public class AppContext : DbContext
    {
        public DbSet<Migrantes> Migrantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
>>>>>>> 8ae61b37e56f96f3c8669ac43aad89064924d60f
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Hackaton");
            }
        }
    }
}


