using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Sobrenome)
                .HasMaxLength(50);

            builder.Property(x => x.Senha)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
