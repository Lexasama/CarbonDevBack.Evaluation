using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refacto.Tests
{
    [TestClass]
    public class CalculateDiscountTests
    {

        [DataTestMethod]
        [DataRow("100.00",  1, 2015)]
        [DataRow("65",  2,  2022)]
        [DataRow("11.16",  3, 2022)]
        [DataRow("9.99",  4, 2022)]
        [DataRow("89.50",  5,  2000)]
        public void CalculateDiscount_and_refactoredCalculateDiscount_should_have_the_same_result(string stringDecimal, int type, int years)
        {
            decimal.TryParse(stringDecimal, out var amount);

            Assert.AreEqual(PriceService.CalculateDiscount(amount, type, years),
                PriceService.RefactoredCalculateDiscount(amount, type, years));
        }

        [TestMethod]
        public void Given_a_non_existing_type_should_return_zero()
        {
            decimal amount = 100m;
            int year = 2045;
            int nonExistingType = 6;
            Assert.AreEqual(PriceService.CalculateDiscount(amount, nonExistingType, year),
                PriceService.RefactoredCalculateDiscount(amount, nonExistingType, year));
        }

      
    }
}