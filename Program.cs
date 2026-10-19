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

            //var ProductList = Source.ProductList
            //               .OrderBy(X => X.Category)
            //               .ThenByDescending(X => X.UnitPrice)
            //               .Select(X => new { X.ProductName, X.UnitPrice, X.Category });

            //foreach (var product in ProductList)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}, Category: {product.Category}");

            #endregion

            #region Q9

            //var ProductList = Source.ProductList
            //               .Where(X => X.Category == "Beverages")
            //               .OrderByDescending(X => X.UnitsInStock)
            //               .Select(X => new { X.ProductName, X.Category, X.UnitsInStock });


            //foreach (var product in ProductList)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");

            #endregion

            #region Q10

            //var Orders = from customer in Source.CustomerList
            //             from order in customer.Orders
            //             where order.OrderDate.Year >= 1997
            //             select new { customer.CustomerID, order.OrderDate };

            //foreach (var order in Orders)
            //    Console.WriteLine($"Customer ID: {order.CustomerID}, Order Date: {order.OrderDate}");

            #endregion

            #region Q11

            //var Products = Source.ProductList
            //    .Select((X, Index) => new { Position = Index + 1, X.ProductName });

            //foreach (var product in Products)
            //    Console.WriteLine($"{product.Position}. {product.ProductName}");

            #endregion

            #region Q12

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var SortedWords = Arr
            //    .OrderBy(X => X.Length)
            //    .ThenBy(X => X, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in SortedWords)
            //    Console.WriteLine(word);

            #endregion

            #region Q13

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var Result = Arr
                .Where(X => X.Length > 1 && char.ToLowerInvariant(X[1]) == 'i')
                .Reverse()
                .ToList();

            foreach (var word in Result)
                Console.WriteLine(word);

            #endregion
        }
    }
}
