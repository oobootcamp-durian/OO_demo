using System;

namespace OO_demo
{
    public class AirCoin
    {
        private long Amount { get;}
        private Unit Unit { get; }

        public AirCoin(long amount, Unit unit)
        {
            Amount = amount;
            this.Unit = unit;
        }

        public bool Compare(AirCoin airCoin)
        {
            return airCoin != null && GetAirCoinValue() == airCoin.GetAirCoinValue();            
        }

        // value = amount combine unit
        private long GetAirCoinValue()
        {
            return Amount * (long) Unit;
        }
    }
}