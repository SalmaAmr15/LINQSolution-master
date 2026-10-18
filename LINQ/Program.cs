using static LINQ.DataSources.Source;
//using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Question1
			//1. Get all products from the "Seafood" category. Print each
			//product's name and price.
			//var result = ProductList.Where(p => p.Category == "Seafood").Select(p=> new {p.ProductName , p.UnitPrice });
			//foreach(var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question2 
			//2. Get a list of only the product names from ProductList. Print
			//each name.
			//var result = ProductList.Select(p => p.ProductName);
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question3 
			//3. Sort all products by UnitPrice (ascending). Print each
			//product's name and price.
			//var result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question4
			//4. Get all products where UnitPrice is between 10 and 30
			var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion



		}
	}
}
