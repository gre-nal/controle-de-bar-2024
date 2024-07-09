using System;
using ControleBar;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ControleBar.Infraestrutura.Orm.Compartilhado
{
    public class ControleBarDbContext : DbContext
    {
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Garçom> Garçoms { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ControleBarOrm;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                mesaBuilder.Property(m => m.Numero)
                .IsRequired()
                .HasColumnType("int");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
