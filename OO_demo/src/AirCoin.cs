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
            return airCoin != null && GetAmountByMinUnit() == airCoin.GetAmountByMinUnit();            
        }

        private long GetAmountByMinUnit()
        {
            return Amount * (long) Unit;
        }
    }
}