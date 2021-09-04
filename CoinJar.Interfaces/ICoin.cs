using System;

namespace CoinJar.Interfaces
{
    public interface ICoin
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
