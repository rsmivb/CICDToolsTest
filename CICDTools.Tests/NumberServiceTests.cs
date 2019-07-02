using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CICDTools.Tests
{
    [TestClass]
    public class NumberServiceTests
    {
        [TestMethod]
        [DataRow(false, 1)]
        [DataRow(true, 2)]
        [DataRow(true, 3)]
        [DataRow(false, 4)]
        [DataRow(false, 789)]
        public void CheckNumberIsPrimeTest(bool expectedResult, int candidate)
        {
            var numberService = new NumberService();
            var resultProcessed = numberService.IsPrime(candidate);

            Assert.AreEqual(expectedResult, resultProcessed);
        }
        //[TestMethod]
        //[DataRow(false, 1)]
        //[DataRow(true, 2)]
        //[DataRow(false, 3)]
        //[DataRow(true, 4)]
        //public void CheckIfNumberIsOddTest(bool expectedResult, int candidate)
        //{
        //    var numberService = new NumberService();
        //    var resultProcessed = numberService.IsOdd(candidate);
        //    Assert.AreEqual(expectedResult, resultProcessed);
        //}
    }
}
