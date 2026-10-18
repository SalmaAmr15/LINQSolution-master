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
			var result = ProductList.Where(p => p.Category == "Seafood").Select(p=> new {p.ProductName , p.UnitPrice });
			foreach(var item in result)
			{
				Console.WriteLine(item);
			}
			#endregion

		}
	}
}
