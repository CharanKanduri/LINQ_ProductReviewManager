using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManager;


namespace TestingProductReview
{
    [TestClass]
    public class TestingProductReviewManagement
    {
        [TestMethod]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = AddingProductReview.AddProductInfo();
            Assert.AreEqual(expected, actual);
        }
    }
}
