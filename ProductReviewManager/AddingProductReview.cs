using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManager
{
   public class AddingProductReview
    {
        public static List<ProductReview> productReviews = new List<ProductReview>();
        public static int AddProductInfo()
        {
            productReviews.Add(new ProductReview() { productId = 1, userId = 1, review = "Bad", rating = 2, isLike = true });
            productReviews.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 5, isLike = false });
            productReviews.Add(new ProductReview() { productId = 3, userId = 3, review = "Nice", rating = 2, isLike = true });
            productReviews.Add(new ProductReview() { productId = 4, userId = 5, review = "Bad", rating = 7, isLike = false });
            productReviews.Add(new ProductReview() { productId = 5, userId = 1, review = "Nice", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 6, userId = 6, review = "Average", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 7, userId = 7, review = "Good", rating = 5, isLike = true });
            productReviews.Add(new ProductReview() { productId = 8, userId = 8, review = "Average", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 9, userId = 9, review = "Bad", rating = 3, isLike = false });
            productReviews.Add(new ProductReview() { productId = 10, userId = 4, review = "Average", rating = 3, isLike = true });
            productReviews.Add(new ProductReview() { productId = 11, userId = 9, review = "Good", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 12, userId = 5, review = "Good", rating = 2, isLike = true });
            productReviews.Add(new ProductReview() { productId = 13, userId = 3, review = "Bad", rating = 5, isLike = false });
            productReviews.Add(new ProductReview() { productId = 14, userId = 2, review = "Bad", rating = 4, isLike = false });
            productReviews.Add(new ProductReview() { productId = 15, userId = 9, review = "Average", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 16, userId = 3, review = "Good", rating = 5, isLike = true });
            productReviews.Add(new ProductReview() { productId = 17, userId = 3, review = "Bad", rating = 4, isLike = false });
            productReviews.Add(new ProductReview() { productId = 18, userId = 15, review = "Good", rating = 4, isLike = true });
            productReviews.Add(new ProductReview() { productId = 19, userId = 9, review = "Bad", rating = 2, isLike = false });
            productReviews.Add(new ProductReview() { productId = 20, userId = 1, review = "Good", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 21, userId = 6, review = "Average", rating = 2, isLike = true });
            productReviews.Add(new ProductReview() { productId = 22, userId = 7, review = "Good", rating = 5, isLike = true });
            productReviews.Add(new ProductReview() { productId = 23, userId = 8, review = "Average", rating = 1, isLike = true });
            productReviews.Add(new ProductReview() { productId = 24, userId = 9, review = "Bad", rating = 4, isLike = false });
            productReviews.Add(new ProductReview() { productId = 25, userId = 4, review = "Average", rating = 3, isLike = true });

            return productReviews.Count;
        }
        public int RetrieveTop3()
        {
            AddProductInfo();
           
            var res = (from product in productReviews 
                       orderby product.rating descending 
                       select product).Take(3).ToList();
            DisplayList();
            return res.Count;
        }
        public string RetrieveRecordsBasedOnRatingAndProductId()
        {
            AddProductInfo();
            string nameList = "";
            Console.WriteLine("\n-----------Retrieve Records Based On Rating and Product Id-----------");
            var productList = (from product in productReviews 
                               where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product);
            foreach (var product in productList)
            {
                nameList += product.userId + " ";
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
            return nameList;
        }
        public string CountingProductId()
        {
            string nameList = "";
            AddProductInfo();
            var productList = productReviews.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count() });
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId " + element.ProductId + " " + "Count " + " " + element.count);
                nameList += element.count + " ";
            }
            return nameList;
        }

        public string RetrieveOnlyProductIdAndReviews()
        {
            string result = "";
            AddProductInfo();
            var productList = productReviews.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId: " + element.ProductId + "\tReview: " + element.Review);
                result += element.ProductId + " ";
            }
            return result;
        }

        public static void DisplayList()
        {
            Console.WriteLine("\n-------- Displaying List Content --------\n");
            foreach (ProductReview product in productReviews)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
