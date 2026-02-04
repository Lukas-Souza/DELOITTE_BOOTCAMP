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
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Minerio>(e =>
            {
                e.ToTable("lotes_minerio_table");

                e.HasIndex(x => x.Id)
                .IsUnique();

                e.Property(x => x.CodElementoQuimico)
                    .IsRequired();

                e.Property(x => x.CodigoMineradora)
                .IsRequired();

                e.Property(x => x.CodLote)
                .IsRequired();

                e.Property(x => x.DataMineracao)
                .IsRequired();

                e.Property(x => x.KiloGrama)
                .IsRequired();
                
                e.Property( x => x.ValorPKilo)
                .IsRequired();
            });
        }
    }
}