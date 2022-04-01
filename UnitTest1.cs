using System;
using Xunit;

namespace tcr
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Fibonacci.GetValueBy(0);
            
            Assert.Equal(0, result);
        }
    }

    public class Fibonacci
    {
        public static int GetValueBy(int position)
        {
            return 0;
        }
    }
}
