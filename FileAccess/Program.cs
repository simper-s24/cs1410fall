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

		foreach (Bird bird in birds)
		{
			Goose? goose = bird as Goose;
			if (bird.GetType() == typeof(Duck))
			{
				Duck duck = (Duck)bird;
				Console.WriteLine(duck.Speak());
			}
			else if (goose != null)
			{
				Console.WriteLine(goose.Speak());
			}
			else if(bird is Penguin)
			{
				Penguin penguin = (Penguin)bird;
				Console.WriteLine(penguin.Speak());
			}
			else
			{
				Console.WriteLine(bird.Speak());
			}
		}
	}
}

public class Bird
{
	protected string FeatherColor = "Brown";
	public string Speak() => "Squawk";
}

public class Duck : Bird
{
	public new string Speak() => "Quack";
	public string GetFeatherColor()
	{
		return FeatherColor;
	}
}

public class Goose :Bird
{
	public new string Speak() => "Honk";
}

public class Penguin :Bird
{
	public new string Speak() => "Coo";
}
