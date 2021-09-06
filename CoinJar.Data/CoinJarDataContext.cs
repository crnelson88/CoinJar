using CoinJar.Entities;
using CoinJar.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoinJar.Data
{
    public class CoinJarDataContext : DbContext
    {


        public CoinJarDataContext(DbContextOptions<CoinJarDataContext> options) : base(options)
        {
        }
        public DbSet<ICoin> Coins { get; set; }
    }
}
