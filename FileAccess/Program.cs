using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


public record Point(double X, double Y, double Z);

internal class Program
{
	private static void Main(string[] args)
	{

		var list = new List<int> { 56, 8, 34, 99, 101, 43, 234, 764, 23, 8, 1, };


		var areas = list
			.Where(InRange)
			.Order()
			.Select(x => x * x * 3.14159)
			.ToList();
		
		areas.ForEach(x => Console.Write(x + ", "));

	}
	static bool InRange(int n)
	{
		//REQ#1.1.3
		return n > 15 && n < 76;
	}
}

