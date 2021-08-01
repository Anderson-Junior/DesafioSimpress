using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DesafioSimpress.Models
{
    public partial class ProdutoStoreModel : DbContext
    {
        public ProdutoStoreModel()
            : base("name=ProdutosStoreEntities")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Produtos)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);
        }
    }
}
