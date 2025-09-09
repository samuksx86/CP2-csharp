using CheckPoint.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Database
{
    public class ConfigurationDb : DbContext
    {
        public DbSet<RM99134_Fornecedor> Fornecedores => Set<RM99134_Fornecedor>();
        public DbSet<RM99134_Produtos> Produtos => Set<RM99134_Produtos>();
        public DbSet<RM99134_Pedido> Pedido => Set<RM99134_Pedido>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database/Products.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RM99134_Fornecedor>(e =>
            {
                e.ToTable("RM99134_Fornecedor");
                e.HasKey(x => x.idFornecedor);
                e.Property(x => x.nrCep).IsRequired().HasMaxLength(8);
                e.Property(x => x.dsEndereco).IsRequired().HasMaxLength(200);
                e.Property(x => x.Estado).IsRequired().HasMaxLength(2);
                e.Property(x => x.Cidade).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<RM99134_Produtos>(e =>
            {
                e.ToTable("RM99134_Produto");
                e.HasKey(x => x.idProduto);
                e.Property(x => x.NmProduto).IsRequired().HasMaxLength(120);
                e.Property(x => x.Preco)
                 .IsRequired();
            });

            modelBuilder.Entity<RM99134_Pedido>(e =>
            {
                e.ToTable("RM99134_Pedido");
                e.HasKey(x => x.idPedido);
                e.Property(x => x.DtPedido).IsRequired();
                e.Property(x => x.ValorTotal)
                 .IsRequired();
            });
        }
    }
}
