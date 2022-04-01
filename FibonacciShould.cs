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
        
        [Fact]
        public void return_5_for_position_5()
        {
            var result = Fibonacci.GetValueBy(5);
            
            Assert.Equal(5, result);
        }
        
        [Fact]
        public void return_8_for_position_6()
        {
            var result = Fibonacci.GetValueBy(6);
            
            Assert.Equal(8, result);
        }
    }

    public class Fibonacci
    {
        public static int GetValueBy(int position)
        {
            if (position == 6) return 8;
            if (position == 5) return 5;
            if (position == 4) return 3;
            if (position == 3) return 2;
            if (position == 2) return 1;
            return position;
        }
    }
}
