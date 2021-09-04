using CoinJar.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoinJar.Data
{
    public class CoinJarDataContext : DbContext
    {


        public CoinJarDataContext(DbContextOptions<CoinJarDataContext> options) : base(options)
        {
        }
        public DbSet<Coin> Coins { get; set; }
    }
}
