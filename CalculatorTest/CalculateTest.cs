using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;
namespace CalculatorTest
{
    public class CalculateTest
    {
        [Fact]
        public void shoule_return_18_when_travle_1km()
        {
            double distance = 1;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance);
            Assert.Equal(18, fee);
        }

        [Fact]
        public void shoule_return_18_when_travle_2km()
        {
            double distance = 1;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance);
            Assert.Equal(18, fee);
        }

        [Fact]
        public void shoule_return_20_when_travle_4km()
        {
            double distance = 4;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance);
            Assert.Equal(20, fee);
        }

        [Fact]
        public void shoule_return_24_when_travle_8km()
        {
            double distance = 8;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance);
            Assert.Equal(24, fee);
        }

        [Fact]
        public void shoule_return_26_4_when_travle_10km()
        {
            double distance = 10;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance);
            Assert.Equal(26.4, fee);
        }

        [Fact]
        public void shoule_return_28_9_when_travle_10km_and_wait_5min()
        {
            double distance = 10;
            double time = 5;
            Calculator.Calculate calculate = new Calculator.Calculate();
            double fee = calculate.theFeeForTaxi(distance,time);
            Assert.Equal(28.9, fee);
        }
    }
}
