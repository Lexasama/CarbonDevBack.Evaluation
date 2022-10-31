using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leap.Tests
{
    [TestClass]
    public class LeapTests
    {
        [DataTestMethod]
        [DataRow(2015, false)]
        [DataRow(2000, true)]
        [DataRow(1997, false)]
        [DataRow(1996, true)]
        [DataRow(1900, false)]
        public void IsLeapYearTest(int year, bool expected)
        {
            Assert.AreEqual(expected, Leap.IsLeapYear(year));
        }
    }
}
