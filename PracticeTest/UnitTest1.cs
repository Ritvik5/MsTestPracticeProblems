using MSTestPracticeProblems;

namespace PracticeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenInput_ShouldReturn_CorrectResult()
        {
            // Arrange
            List<int> prices = new List<int> { 5, 5, 4, 7, 4, 1, 11 };

            // Act
            ShopKeeper soldOnce = new ShopKeeper();
            int result = soldOnce.SoldOnceItem(prices);
            int result2 = soldOnce.SoldMoreThanOnceItem(prices);

            // Assert
            Assert.AreEqual(7, result);
            Assert.AreEqual(5, result2);
        }

    }
}