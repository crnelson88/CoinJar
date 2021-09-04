using CoinJar.Interfaces;

namespace CoinJar.Entities
{
    public class Coin : ICoin
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
