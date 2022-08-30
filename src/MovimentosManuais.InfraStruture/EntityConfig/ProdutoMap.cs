using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;
using System;

namespace MovimentosManuais.InfraStruture.EntityConfig
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.COD_PRODUTO);                        

            builder.Property(e => e.DES_PRODUTO)
                   .HasColumnType("VARCHAR(30)")
                   .IsRequired();

            builder.Property(e => e.STA_STATUS)
                   .HasColumnType("CHAR(1)")
                   .IsRequired();
        }
    }
}
