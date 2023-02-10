using CoinJar.Framework.Interfaces;

namespace CoinJar.Framework.Models
{
    public class Coin : ICoin
    {
        public decimal Amount { get; set; }
        public decimal? Volume { get; set; }
    }
}
