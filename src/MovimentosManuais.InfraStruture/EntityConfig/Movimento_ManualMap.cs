using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;
using System;

namespace MovimentosManuais.InfraStruture.EntityConfig
{
    public class Movimento_ManualMap : IEntityTypeConfiguration<Movimento_Manual>
    {
        public void Configure(EntityTypeBuilder<Movimento_Manual> builder)
        {
            builder.HasKey(t => new { t.DAT_MES, t.DAT_ANO, t.NUM_LANCAMENTO, t.COD_PRODUTO, t.COD_COSIF });

            builder.Property(e => e.DAT_MES)
                   .HasColumnType("NUMERIC(2,0)");

            builder.Property(e => e.DAT_ANO)
                   .HasColumnType("NUMERIC(4,0)");            

            builder.Property(e => e.NUM_LANCAMENTO)
                   .HasColumnType("NUMERIC(18,0)");

            builder.Property(e => e.COD_PRODUTO)
                   .HasColumnType("CHAR(4)");

            builder.Property(e => e.COD_COSIF)
                   .HasColumnType("CHAR(11)");

            builder.Property(e => e.DES_DESCRICAO)
                   .HasColumnType("VARCHAR(50)");

            builder.Property(e => e.DAT_MOVIMENTO)
                   .HasColumnType("SMALLDATETIME");

            builder.Property(e => e.COD_USUARIO)
                   .HasColumnType("VARCHAR(15)");

            builder.Property(e => e.VAL_VALOR)
                   .HasColumnType("NUMERIC(18,2)");                   
        }
    }
}
