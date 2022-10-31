using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calcul
{

    /*
      1- Corriger les tests unitaires en erreur
      2- Décommenter le test Test_Factorial et corriger le test
      3- Implémenter les tests associés à la methode Fraction de ICalculusServices
    */


    [TestClass]
    public class CalculusServicesUnitTest
    {
        [TestMethod]
        public void Test_Add()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 20;
            var result = calculusServices.Add(10, 10);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Diff()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 0;
            var result = calculusServices.Diff(10, 10);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Factorial()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 120;
            var result = calculusServices.Factorial(5);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(20, 5, 20/5)]
        [DataRow(20.00, 5.0, 20.00 / 5.0)]
        public void Test_Fraction(double a, double b , double expected)
        {
            ICalculusServices sut = new CalculusServices();
          
            var result = sut.Fraction(a, b);
            Assert.AreEqual(expected, result);
        }


    }
}
