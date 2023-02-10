using CoinJar.Framework.DbConnector;
using CoinJar.Framework.Helpers;
using CoinJar.Framework.Interfaces;
using System.Text.Json.Serialization;

namespace CoinJar.Framework.Classes
{
    public class CoinJarVm : ICoinJar
    {
        SqlDataContext DataContext = new SqlDataContext();
        public CoinJarVm()
        {

        }

        public void AddCoin(ICoin coin)
        {
            decimal? weightOfCoin = CoinHelper.GetCoinWeightsFromValue(coin);
            DataContext.DatabaseObjects.AddCoinToCoinJar(coin.Amount, weightOfCoin);
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
