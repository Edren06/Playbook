using CoinJar.Framework.Interfaces;

namespace CoinJar.Framework.Helpers
{
    //Helper class to return weights from coins entered.
    public static class CoinHelper
    {
        public static Decimal GetCoinWeightsFromValue(ICoin coin)
        {
            if (coin.Volume.GetValueOrDefault(0) != 0) return coin.Volume.Value;

            switch (coin.Amount)
            {
                //Penny
                case 1:
                    return (Decimal)0.088;
                case 5:
                    return (Decimal)0.176;
                case 10:
                    return (Decimal)0.08;
                case 25:
                    return (Decimal)0.2;
                case 50:
                    return (Decimal)0.4;
                case 100:
                    return (Decimal)0.286;
                default:
                    throw new ApplicationException("There is no US coin with that value");
            }
        }
    }
}
