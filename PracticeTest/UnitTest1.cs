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

        [TestMethod]
        public void IsEligible_ShouldReturn_Yes()
        {
            //Arrange
            List<string> words = new List<string> { "part" ,"trap" };
            SwapCompetition swap = new SwapCompetition();

            //Act
            string result = swap.IsEligible(words);

            //Arrange
            Assert.AreEqual("Yes", result);

        }

        [TestMethod]

        public void IsEligible_ShouldReturn_No()
        {
            //Arrange
            List<string> words = new List<string> { "noon", "moon" };
            SwapCompetition swap = new SwapCompetition();

            //Act
            string result = swap.IsEligible(words);

            //Arrange
            Assert.AreEqual("No", result);
        }
    }
}