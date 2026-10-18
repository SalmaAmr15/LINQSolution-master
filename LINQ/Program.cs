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
			//var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question5
			//5. Get all products that are in stock (UnitsInStock > 0) and
			//belong to the "Condiments" category.
			//var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question6
			//6.Create a new anonymous type with three properties:
			//● Name → the product name
			//● Price → the unit price
			//● StockStatus → a string: "Available" if UnitsInStock > 0,
			//otherwise "Out of Stock"
			//● Print the result.
			//var result = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" 
			//});
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question7
			//7. Print each product's name along with its position (1-based)
			//in the list. Expected format: 1.Chai, 2.Chang, etc.
			// var result = ProductList.Select((p, i) => new { position= i + 1,  p.ProductName });
			//foreach (var item in result)
			//{
			//	Console.WriteLine($"{item.position}. {item.ProductName}");
			//}
			#endregion

			#region Question8
			//8. Sort ProductList by Category ascending, then within each
			//category, sort by UnitPrice descending.
			//var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
			//foreach (var item in result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Question9
			//9. Get all products from the "Beverages" category, sorted by
			//UnitsInStock descending. Print name and stock.
			var result = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock)
				.Select(p => new { p.ProductName, p.UnitsInStock });
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

		}
	}
}
