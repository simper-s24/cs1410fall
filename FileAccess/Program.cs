using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


public record Point(double X, double Y, double Z);

internal class Program
{
	public delegate int NumberDelegate(int number);

	private static void Main(string[] args)
	{
		DateTime now = DateTime.UtcNow;
		Console.WriteLine(now.ToSqlDate());

		var items = new List<int> { 67, 345, 5, 6, 87, 9, 3, 43, 4, 34, 35 };
		var ie = items.ApplyMethod(i => i - 23);

		ie = ie.OrderBy(x => x % 5, "asc");

		//ie.ToList().ForEach(i => Console.Write(i + ", "));


		var people = new List<Person> {
			new Person("Ethan", "Hintze", 2004),
			new Person("Tyson", "Meade", 2003)
			};

		var sorted = people.OrderBy(p => DateTime.UtcNow.Year - p.BirthYear, "desc");
		sorted.ToList().ForEach(p => Console.Write(p.FirstName + ", " + p.BirthYear + "; "));
	}
}


public record Person(string FirstName, string LastName, int BirthYear);

public static class DateTimeExtensions
{
	public static string ToSqlDate(this DateTime date)
	{
		return date.ToString("yyyy-MM-dd");
	}

	public static IEnumerable<T> OrderBy(this IEnumerable<T> list,
		Func<Person, T> func, string order)
	{
		return list.OrderBy<T>(i => func(i));
	}
	public static IEnumerable<int> OrderBy(this IEnumerable<int> list,
		Func<int, int> sortFunction, string order)
	{
		if (order == "desc")
		{
			return list.OrderByDescending(c => sortFunction(c));
		}
		return list.OrderBy(c => sortFunction(c));

	}

	public static IEnumerable<int> ApplyMethod(this IEnumerable<int> list,
		Func<int, int> fun)
	{
		return list.Select(x => fun(x));
	}
}