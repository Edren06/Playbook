using CoinJar.Framework.DbConnector;
using CoinJar.Framework.Interfaces;
using System.Text.Json.Serialization;

namespace CoinJar.Framework.Classes
{
    public class CoinJar : ICoinJar
    {
        [JsonIgnore]
        SqlDataContext DataContext = new SqlDataContext();
        public CoinJar()
        {

        }

        public void AddCoin(ICoin coin)
        {
            DataContext.DatabaseObjects.AddCoinToCoinJar(coin.Amount, coin.Volume);
        }

        public Decimal GetTotalAmount()
        {
            return DataContext.DatabaseObjects.GetCoinJar().SingleOrDefault().Amount;
        }

        public void Reset()
        {
            DataContext.DatabaseObjects.ResetCoinJar();
        }
    }
}
