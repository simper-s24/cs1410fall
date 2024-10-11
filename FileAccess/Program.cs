using System.IO;
using System.Threading.Tasks;


public record Point(double X, double Y);

internal class Program
{
	private static void Main(string[] args)
	{

		Point p1 = new Point(3, 4);
		p1 = new Point(5, 6);
		Point p2 = p1 with { X = 7, Y = 6 };
		p2 = p2 with { Y = 13 };
		Point p3 = p1 with { X = 5 };
		Point p4 = new Point(p1.X, p2.Y);

		List<Bird> birds = new List<Bird>
		{
			new Duck(),
			new Goose(),
			new Penguin(),
		};

		Duck d = new Duck();
		birds.Add(d);


		if (false) return;

		foreach (Bird bird in birds)
		{
			Console.WriteLine(bird.Speak()); 
			Console.WriteLine();
		}

		List<Penguin> plist = new List<Penguin>
		{
			new FairyPenguin(),
			new Penguin()
		};

		birds.AddRange(plist);
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
