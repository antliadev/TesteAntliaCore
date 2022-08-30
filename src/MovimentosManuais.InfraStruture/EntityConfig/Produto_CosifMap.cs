using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;
using System;

namespace MovimentosManuais.InfraStruture.EntityConfig
{
    public class Produto_CosifMap : IEntityTypeConfiguration<Produto_Cosif>
    {
        public void Configure(EntityTypeBuilder<Produto_Cosif> builder)
        {
            builder.HasKey(t => new { t.COD_PRODUTO, t.COD_COSIF });

            builder.Property(e => e.COD_COSIF)
                   .HasColumnType("CHAR(11)");                   

            builder.Property(e => e.COD_CLASSIFICACAO)
                   .HasColumnType("CHAR(6)")
                   .IsRequired();

            builder.Property(e => e.STA_STATUS)
                   .HasColumnType("CHAR(1)")
                   .IsRequired();
        }
    }
}
