using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManager;


namespace TestingProductReview
{
    [TestClass]
    public class TestingProductReviewManagement
    {
        AddingProductReview review;
        [TestInitialize]
        public void SetUp()
        {
            review = new AddingProductReview();

        }

        [TestMethod]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = AddingProductReview.AddProductInfo();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenRetrieveTop3_ReturnInt()
        {
            int expected = 3;
            var actual = review.RetrieveTop3();
            Assert.AreEqual(expected, actual);
        }

        //Usecase 3: Retrieve records from list based on productid and rating > 3 
        [TestMethod]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            string expected = "5 ";
            string actual = review.RetrieveRecordsBasedOnRatingAndProductId();
            Assert.AreEqual(expected, actual);
        }

    }
}
