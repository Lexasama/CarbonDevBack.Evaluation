using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refacto.Tests
{
    [TestClass]
    public class Class1
    {

        [DataTestMethod]
        public void test() {

            PriceService.CalculateDiscount(100, 1, 2015);

        }

    }
}