using LINQ.DataSources;
using LINQ.Models;

namespace Assignment_01_LinqC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            var AllProducts = Source.ProductList
                             .Where(N => N.Category == "Seafood")
                             .Select(X => new { X.ProductName, X.UnitPrice });

            foreach (var product in AllProducts)
                Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion



        }
    }
}
