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

        [TestMethod]
        public void TestMethodForCountingProductId()
        {
            string expected = "1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 ";
            string actual = review.CountingProductId();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForProductId()
        {
            string expected = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 ";
            string actual = review.RetrieveOnlyProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }

    }
}
