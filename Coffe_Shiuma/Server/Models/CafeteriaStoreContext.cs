using Coffe_Shiuma.Shared;
using Microsoft.EntityFrameworkCore;

namespace Coffe_Shiuma.Server.Models
{
    public class CafeteriaStoreContext : DbContext
    {
        public DbSet<CafeSpecial> Specials { get; set; }
        public CafeteriaStoreContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}