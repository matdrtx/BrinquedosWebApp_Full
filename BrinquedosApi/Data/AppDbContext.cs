using BrinquedosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BrinquedosApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Brinquedo> Brinquedos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brinquedo>().ToTable("TDS_TB_BRINQUEDOS");

        modelBuilder.Entity<Brinquedo>(entity =>
        {
            entity.HasKey(b => b.Id_brinquedo);

            entity.Property(b => b.Id_brinquedo).HasColumnName("ID_BRINQUEDO");
            entity.Property(b => b.Nome_brinquedo).HasColumnName("NOME_BRINQUEDO");
            entity.Property(b => b.Tipo_brinquedo).HasColumnName("TIPO_BRINQUEDO");
            entity.Property(b => b.Classificacao).HasColumnName("CLASSIFICACAO");
            entity.Property(b => b.Tamanho).HasColumnName("TAMANHO");
            entity.Property(b => b.Preco).HasColumnName("PRECO");
        });
    }
}
