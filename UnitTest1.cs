using System;
using Xunit;

namespace tcr
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Fibonacci.Fib(0);
            
            Assert.Equal(0, result);
        }
    }

    public class Fibonacci
    {
        public static int Fib(int i)
        {
            return 0;
        }
    }
}
