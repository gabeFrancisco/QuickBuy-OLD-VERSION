using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasMaxLength(12)
                .IsRequired();
        }
    }
}
