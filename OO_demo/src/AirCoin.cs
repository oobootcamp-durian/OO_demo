using System;

namespace OO_demo
{
    public class AirCoin
    {
        private long Amount { get;}
        private UNIT Unit { get; }

        public AirCoin(long amount, UNIT unit)
        {
            Amount = amount;
            this.Unit = unit;
        }

        public bool Compare(AirCoin airCoin)
        {
            
            return airCoin != null && Unit == airCoin.Unit  && Amount == airCoin.Amount;            
        }
        
    }
}