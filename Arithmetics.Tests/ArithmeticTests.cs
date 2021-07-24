using Xunit;

namespace Arithmetics.Tests
{
    public class ArithmeticTests
    {
        [Fact]
        public void TestAdd()
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.Add(10, 100);
            Assert.Equal(110, result);
        }

        [Fact]
        public void TestSubs()
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.Subs(10, 100);
            Assert.Equal(-90, result);
        }
    }
}
