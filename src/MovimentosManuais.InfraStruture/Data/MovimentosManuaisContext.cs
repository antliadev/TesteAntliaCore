using Microsoft.EntityFrameworkCore;
using MovimentosManuais.ApplicationCore.Entity;
using MovimentosManuais.InfraStruture.EntityConfig;

namespace MovimentosManuais.InfraStruture.Data
{
    public class MovimentosManuaisContext : DbContext 
    {
        public MovimentosManuaisContext(DbContextOptions<MovimentosManuaisContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto_Cosif> Produto_Cosifs { get; set; }
        public DbSet<Movimento_Manual> MovimentosManuais { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Add name tables         
            builder.Entity<Produto>().ToTable("PRODUTO");
            builder.Entity<Produto_Cosif>().ToTable("PRODUTO_COSIF");
            builder.Entity<Movimento_Manual>().ToTable("MOVIMENTO_MANUAL");

            //Mapping tables .... 
            builder.ApplyConfiguration(new Movimento_ManualMap());
            builder.ApplyConfiguration(new Produto_CosifMap());
            builder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
