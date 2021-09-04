using CoinJar.Data;
using CoinJar.Interfaces;
using System;
using System.Linq;

namespace CoinJar.Logic
{
    public class CoinJar : ICoinJar
    {
        private readonly CoinJarDataContext _coinJarDataContext;

        public CoinJar(CoinJarDataContext coinJarDataContext)
        {
            _coinJarDataContext = coinJarDataContext;
        }
        public void AddCoin(ICoin coin)
        {
            if (_coinJarDataContext.Coins.Sum(x => x.Volume) + coin.Volume > 42)
            {
                throw new Exception();
            }
            _coinJarDataContext.Add(coin);
            _coinJarDataContext.SaveChanges();
        }

        public decimal GetTotalAmount()
        {
            return _coinJarDataContext.Coins.Sum(x => x.Amount);
        }

        public void Reset()
        {
            _coinJarDataContext.Coins.RemoveRange(_coinJarDataContext.Coins);
            _coinJarDataContext.SaveChanges();
        }
    }
}
