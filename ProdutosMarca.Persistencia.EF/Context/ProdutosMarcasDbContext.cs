using ProdutosMarcas.Dominio;
using System.Data.Entity;

namespace ProdutosMarca.Persistencia.EF.Context
{
    public class ProdutosMarcasDbContext : DbContext 
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        public ProdutosMarcasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasRequired(p => p.Marca) //um produto requer um marca
                .WithMany(p => p.Produtos) //marca pode ter varios produtos
                .HasForeignKey(fk => fk.MarcaId) //chave estrangeira MarcaId
                .WillCascadeOnDelete(false); //exclusao em cascata desativada
        }
    }
}