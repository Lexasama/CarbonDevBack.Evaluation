using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leap.Tests
{
    [TestClass]
    public class LeapTests
    {

        [DataTestMethod]
        [DataRow(2000)]
        [DataRow(1996)]
        public void given_a_leap_year_should_return_true(int year)
        {
            Assert.IsTrue(Leap.IsLeapYear(year));
        }

        [DataTestMethod]
        [DataRow(2015)]
        [DataRow(1997)]
        [DataRow(1900)]
        public void given_a_NON_leap_year_should_return_false(int year)
        {
            Assert.IsFalse(Leap.IsLeapYear(year));
        }


        [DataTestMethod]
        [DataRow(2000)]
        [DataRow(2400)]
        [DataRow(2800)]
        public void given_a_multiple_of_400_should_return_true(int year)
        {
            Assert.IsTrue(Leap.IsLeapYear(year));
        }

        [DataTestMethod]
        [DataRow(2100)]
        [DataRow(2013)]
        [DataRow(2002)]
        [DataRow(1999)]
        public void given_a_year_NOT_divible_by_4_should_return_false(int year)
        {
            Assert.IsFalse(Leap.IsLeapYear(year));
        }

        [DataTestMethod]
        [DataRow(2100)]
        [DataRow(2500)]
        [DataRow(1300)]
        [DataRow(1900)]
        public void given_a_mulitple_of_100_and_not_a_mutiple_of_400_should_return_false(int year)
        {
            Assert.IsFalse(Leap.IsLeapYear(year));
        }
    }
}
