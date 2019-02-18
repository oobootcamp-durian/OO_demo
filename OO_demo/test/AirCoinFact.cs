using Xunit;

namespace OO_demo.test
{
    public class AirCoinFact
    {
//        [Fact]
//        public void should_return_true_when_amount_value_equal()
//        {
//            var airCoin1 = new AirCoin(10);
//            var airCoin2 = new AirCoin(10);
//            Assert.Equal(true, airCoin1.Equals(airCoin2));
//        }

        [Fact]
        public void should_return_false_when_amount_value_and_unit_not_equal()
        {
            var airCoin1 = new AirCoin(10, UNIT.Gold);
            var airCoin2 = new AirCoin(10, UNIT.Silver);
            
            Assert.Equal(false, airCoin1.Equals(airCoin2));
        }
    }
}