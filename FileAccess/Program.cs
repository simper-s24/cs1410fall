using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


public record Point(double X, double Y, double Z);

internal class Program
{
	private static void Main(string[] args)
	{

		Point p1 = new Point(3, 4,1 );
		p1 = new Point(5, 6, 1);
		Point p2 = p1 with { X = 7, Y = 6 };
		p2 = p2 with { Y = 13 };
		Point p3 = p1 with { X = 5 };
		Point p4 = new Point(p1.X, p2.Y, 0);

		List<Point> points = new List<Point>{
			p1, p2, p3, p4
		};

		string pointstring = JsonSerializer.Serialize(points);
		Console.WriteLine(pointstring);

		string info = "[{\"X\":5,\"Y\":6},{\"X\":7,\"Y\":13},{\"X\":5,\"Y\":6},{\"X\":5,\"Y\":13}]";
		List<Point> points2 = JsonSerializer.Deserialize<List<Point>>(info);

		
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

public class Goose :Bird
{
	public override string FeatherColor()
	{
		return "gray";
	}

	public override string Speak() => "Honk";
}

public class Penguin :Bird
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
