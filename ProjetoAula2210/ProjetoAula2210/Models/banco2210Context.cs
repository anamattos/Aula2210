using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoAula2210.Models
{
    public partial class banco2210Context : DbContext
    {
        public banco2210Context()
        {
        }

        public banco2210Context(DbContextOptions<banco2210Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Produtos> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.HasKey(e => e.ProdCodigo);

                entity.Property(e => e.ProdCodigo).HasColumnName("Prod_Codigo");

                entity.Property(e => e.ProdNome)
                    .IsRequired()
                    .HasColumnName("Prod_Nome")
                    .HasMaxLength(20);

                entity.Property(e => e.ProdPreco)
                    .HasColumnName("Prod_Preco")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ProdQtde).HasColumnName("Prod_Qtde");
            });
        }
    }
}
