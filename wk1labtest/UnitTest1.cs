namespace wk1labtest
{
    public class UnitTest1
    {
        [Fact]
        public void Divide_EightbyFour_EqualsTwo()
        {
            int a = 8;
            int b = -4;
            Assert.Equal(2, Divide(a, b));
        }

        public double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
