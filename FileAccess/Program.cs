using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


public record Point(double X, double Y, double Z);

internal class Program
{
	public delegate int NumberDelegate(int number);

	private static void Main(string[] args)
	{
		NumberDelegate fun1 = AddOne;
		NumberDelegate g = (x => x*2);

		int b = Bar(76, fun1);
		int b2 = Bar2(76, AddOne);
		Bar3(5, PrintInt);
		Bar4(7, IsPrime);

		Console.WriteLine(b);
	}

	private static int Bar(int c1, NumberDelegate fun){
		return fun.Invoke(c1);
	}

	private static int Bar2(int c1, Func<int, int> fun){
		return fun.Invoke(c1);
	}
	private static void Bar3(int c1, Action<int> fun){

	}
	private static void Bar4(int a, Func<int, bool> fun){
	}
	private static void Bar5(int a, Predicate<int> fun){

	}

	private static int AddOne(int a)
	{
		return a + 1;
	}

	private static void PrintInt(int a){
		Console.WriteLine(a);
	}

	private static bool IsPrime(int a){
		return false;
	}

}

