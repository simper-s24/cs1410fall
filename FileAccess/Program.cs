using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


public record Point(double X, double Y, double Z);

internal class Program
{
	private static void Main(string[] args)
	{

		var list = new List<int> { 56, 8, 34, 99, 101, 43, 234, 764, 23, 8, 1, };

		var filtered = list.Where(InRange).ToList();

		var sublist = new List<int>();

		foreach (int n in list)
		{
			if (InRange(n))
			{
				sublist.Add(n);
			}
		}

	}
	static bool InRange(int n)
	{
		return n > 34 && n < 98;
	}
}


public class Duck : Bird
{
	public override string Speak() => "Quack";
	public override string FeatherColor()
	{
		return "Green/Brown";
	}
}

public class Goose : Bird
{
	public override string FeatherColor()
	{
		return "gray";
	}

	public override string Speak() => "Honk";
}

public class Penguin : Bird
{
	public override string FeatherColor()
	{
		return "Black/White";
	}

	public override string Speak() => "Coo";
}

public class FairyPenguin : Penguin
{

}

public class Sparrow : Bird
{
	public override string FeatherColor()
	{
		return "Black";
	}
}
