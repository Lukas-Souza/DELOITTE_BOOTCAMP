using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options): base(options){}
        public DbSet<Equipaments> Equipaments => Set<Equipaments>();
          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                //  Schema
                modelBuilder.HasDefaultSchema("constraints");

                // Insert 

                modelBuilder.Entity<Equipaments>(e =>
                {
                    e.ToTable("equipamentos", schema: "constraints"); // tabela com schema constraints
                    e.HasKey(e => e.Id);                           // chave primária
            
    e.Property(e => e.Id)
    .HasColumnName("id")
    .ValueGeneratedOnAdd();


                    e.Property(e => e.Codigo).HasColumnName("codido");
                    e.Property(e => e.Tipo).HasColumnName("tipo");
                    e.Property(e => e.Modelo).HasColumnName("modelo");
                    e.Property(e => e.Horimetro).HasColumnName("horimetro");
                    e.Property(e => e.StatusOperacional).HasColumnName("status_operacional");
                    e.Property(e => e.DataAquisicao).HasColumnName("data_aquisicao");
                    e.Property(e => e.LocalizacaoAtual).HasColumnName("local_atual");
                });

            }
            catch (Exception err)
            {
                
                Console.WriteLine("Ocorreu um erro no AppDBCOntext: " + err);
            }

            
  
        }
    }
}