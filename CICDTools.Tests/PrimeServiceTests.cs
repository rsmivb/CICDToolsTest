using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CICDTools.Tests
{
    [TestClass]
    public class PrimeServiceTests
    {
        private PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }
        [TestMethod]
        [DataRow(false, 1)]
        [DataRow(true, 2)]
        [DataRow(true, 3)]
        [DataRow(false, 4)]
        [DataRow(false, 789)]
        public void TestMethod1(bool expectedResult, int candidate)
        {
            var resultProcessed = _primeService.IsPrime(candidate);

            Assert.AreEqual(expectedResult, resultProcessed);
        }
    }
}
