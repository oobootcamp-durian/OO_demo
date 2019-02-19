using System;
using Xunit;

namespace OO_demo.test
{
    public class AirCoinFact
    {
        [Fact]
        public void should_return_true_when_amount_value_and_unit_equal()
        {
            var airCoin1 = new AirCoin(10, Unit.Gold);
            var airCoin2 = new AirCoin(10, Unit.Gold);

            Assert.True(airCoin1.Compare(airCoin2));
        }
        
        [Fact]
        public void should_return_false_when_amount_value_and_unit_not_equal()
        {
            var airCoin1 = new AirCoin(10, Unit.Gold);
            var airCoin2 = new AirCoin(10, Unit.Silver);

            Assert.False(airCoin1.Compare(airCoin2));
        }

        [Fact]
        public void should_return_true_when_actual_value_equal_and_unit_not_equal()
        {
            var airCoin1 = new AirCoin(1, Unit.Gold);
            var airCoin2 = new AirCoin(10, Unit.Silver);

            Assert.True(airCoin1.Compare(airCoin2));
        }

        [Fact]
        public void should_return_false_when_actual_value_not_equal_and_unit_not_equal()
        {
            var airCoin1 = new AirCoin(1, Unit.Gold);
            var airCoin2 = new AirCoin(12, Unit.Silver);

            Assert.False(airCoin1.Compare(airCoin2));
        }

        [Fact]
        public void should_return_false_when_second_coin_is_null()
        {
            var airCoin1 = new AirCoin(1, Unit.Gold);
            AirCoin airCoin2 = null;
            Assert.False(airCoin1.Compare(airCoin2));
        }

        [Fact]
        public void should_throw_exception_when_first_coin_is_null()
        {
            AirCoin airCoin1 = null;
            var airCoin2 = new AirCoin(1, Unit.Gold);
            Assert.Throws<NullReferenceException>(() => airCoin1.Compare(airCoin2));
        }
    }
}