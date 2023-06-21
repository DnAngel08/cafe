using Coffe_Shiuma.Shared;
using Microsoft.EntityFrameworkCore;

namespace Coffe_Shiuma.Server.Models
{
    public class CafeteriaStoreContext : DbContext
    {
        public DbSet<CafeSpecial> Specials { get; set; }
        public DbSet<Bebida> Toppings { get; set; }
        public DbSet<Cafe> Pizzas { get; set; }
        public CafeteriaStoreContext(DbContextOptions options)
        : base(options)
        {

        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir la llave primaria de la entidad PizzaTopping
            modelBuilder.Entity<CafeBebida>()
            .HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            // Una Pizza puede tener muchos Toppings.
            modelBuilder.Entity<CafeBebida>()
            .HasOne<Cafe>().WithMany(ps => ps.Bebidas);
            // Un Topping puede estar en muchas Pizzas.
            modelBuilder.Entity<CafeBebida>()
            .HasOne(pst => pst.Bebida).WithMany();
        }
    }
}