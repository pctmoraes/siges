using Empresa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Empresa.Infra.Data.Sql.Context
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<LinhasPedido>()
               .HasKey(pt => new { pt.LinhasId });

            builder.Entity<LinhasPedido>()
                .HasOne(t => t.Item);

            builder.Entity<Pedido>()
                .HasMany(t => t.LinhasPedidos);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=<SQL-server-name>\\SQLEXPRESS;Initial Catalog=empresa;persist security info=True;user id=<SQL-ID>;password=<SQL-password>");
            base.OnConfiguring(builder);
        }

        public DbSet<Domain.Entities.Empresa> Empresas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<LinhasPedido> LinhasPedidos { get; set; }

    }
}
