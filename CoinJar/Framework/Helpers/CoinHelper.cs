using CoinJar.Framework.Interfaces;

namespace CoinJar.Framework.Helpers
{
    //Helper class to return weights from coins entered.
    public static class CoinHelper
    {
        public static Decimal GetCoinWeightsFromValue(ICoin coin)
        {
            //This just here in case the user does not input the volume and it will be calculated below in the switch statement.
            if (coin.Volume.GetValueOrDefault(0) != 0) return coin.Volume.Value;

            switch (coin.Amount)
            {
                //Penny
                case 1:
                    return (Decimal)0.088;
                //Nickel
                case 5:
                    return (Decimal)0.176;
                //Dime
                case 10:
                    return (Decimal)0.08;
                //Quarter
                case 25:
                    return (Decimal)0.2;
                //Half Dollar
                case 50:
                    return (Decimal)0.4;
                //Dollar
                case 100:
                    return (Decimal)0.286;
                default:
                    throw new ApplicationException("There is no US coin with that value");
            }
        }
    }
}
