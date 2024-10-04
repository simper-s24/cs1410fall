using System.IO;
using System.Threading.Tasks;


internal class Program
{
	private static void Main(string[] args)
	{
		List<Bird> birds = new List<Bird>
		{
			new Bird(),
			new Duck(),
			new Goose(),
			new Penguin(),
		};

		if (false) return;

		foreach (Bird bird in birds)
		{
			Console.WriteLine(bird.Speak()); 
			Console.WriteLine();
		}
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

public class Sparrow : Bird
{
	public override string FeatherColor()
	{
		return "Black";
	}
}
