using System;
using Xunit;

namespace tcr
{
    public class FibonacciShould
    {
        [Fact]
        public void return_0_for_position_0()
        {
            var result = Fibonacci.GetValueBy(0);
            
            Assert.Equal(0, result);
        }

        [Fact]
        public void return_1_for_position_1()
        {
            var result = Fibonacci.GetValueBy(1);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void return_1_for_position_2()
        {
            var result = Fibonacci.GetValueBy(2);
            
            Assert.Equal(1, result);
        }
    }

    public class Fibonacci
    {
        public static int GetValueBy(int position)
        {
            if (position > 1) return 1;
            return position;
        }
    }
}
