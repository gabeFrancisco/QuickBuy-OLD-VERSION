using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataPedido)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.DataPrevisaoEntrega)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.CEP)
                .HasMaxLength(10);

            builder.Property(x => x.Estado)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.EnderecoCompleto)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.NumeroEndereco)
                .IsRequired();

            builder.HasOne(x => x.Usuario);
        }
    }
}
