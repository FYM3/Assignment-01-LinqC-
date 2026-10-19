using LINQ.DataSources;
using LINQ.Models;

namespace Assignment_01_LinqC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //var AllProducts = Source.ProductList
            //                 .Where(N => N.Category == "Seafood")
            //                 .Select(X => new { X.ProductName, X.UnitPrice });

            //foreach (var product in AllProducts)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q2

            //var ProductName = Source.ProductList.Select(X => X.ProductName);

            //foreach (var product in ProductName)
            //    Console.WriteLine($"Product Name: {product}");

            #endregion

            #region Q3

            //var Sortallproducts = Source.ProductList
            //                    .OrderBy(X => X.UnitPrice)
            //                    .Select(X => new { X.ProductName, X.UnitPrice });

            //foreach (var product in Sortallproducts)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q4

            //var Productsbetween = Source.ProductList
            //                    .Where(X => X.UnitPrice >= 10 && X.UnitPrice <= 30)
            //                    .Select(X => new { X.ProductName, X.UnitPrice });

            //foreach (var product in Productsbetween)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q5

            //var Allproducts = Source.ProductList
            //               .Where(X => X.UnitsInStock > 0 && X.Category == "Condiments")
            //               .Select(X => new { X.ProductName, X.UnitsInStock, X.Category });

            //foreach (var product in Allproducts)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}, Category: {product.Category}");

            #endregion

            #region Q6

            //var anonymous = Source.ProductList
            //           .Select(X => new { X.ProductName, X.UnitPrice , StockStatus = (X.UnitsInStock > 0) ? "Available" : "Out of Stock" });

            //foreach (var product in anonymous)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}, Stock Status: {product.StockStatus}");

            #endregion

            #region Q7

            //var ProductName = Source.ProductList
            //    .Select((X,Index) => new { X.ProductName, Position = Index + 1 });

            //foreach (var product in ProductName)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Position: {product.Position}");

            #endregion

            #region Q8

            var ProductList = Source.ProductList
                           .OrderBy(X => X.Category)
                           .ThenByDescending(X => X.UnitPrice)
                           .Select(X => new { X.ProductName, X.UnitPrice, X.Category });

            foreach (var product in ProductList)
                Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}, Category: {product.Category}");

            #endregion

        }
    }
}
