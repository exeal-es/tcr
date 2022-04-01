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
        
        [Fact]
        public void return_2_for_position_3()
        {
            var result = Fibonacci.GetValueBy(3);
            
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void return_3_for_position_4()
        {
            var result = Fibonacci.GetValueBy(4);
            
            Assert.Equal(3, result);
        }
    }

    public class Fibonacci
    {
        public static int GetValueBy(int position)
        {
            if (position > 1)
            {
                return position-1;
            }
            return position;
        }
    }
}
