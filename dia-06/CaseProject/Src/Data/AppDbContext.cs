using Microsoft.EntityFrameworkCore;
using Models;

namespace MinhaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Minerio> LotesMinerio => Set<Minerio>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.HasDefaultSchema("public");

                modelBuilder.Entity<Minerio>(e =>
            {
                e.ToTable("lote_minerio_table");
                e.HasKey(e => e.Id); 
                e.Property(e => e.Kilograma).HasColumnName("kilograma");
             // Define a chave primária
        
        e.Property(e => e.Id).HasColumnName("id");

            });
            }
            catch (Exception err)
            {
                
                Console.WriteLine("Ocorreu um erro: " + err);
            }
  
        }
    }
}