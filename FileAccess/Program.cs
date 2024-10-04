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
			Console.WriteLine(bird.Speak());
		}
	}
}

public class Bird
{
	
	protected string FeatherColor = "Brown";
	public string Speak() {
		
		Goose? goose = this as Goose;
		if (this.GetType() == typeof(Duck))
		{
			Duck duck = (Duck)this;
			return duck.Speak();
		}
		else if (goose != null)
		{
			return goose.Speak();
		}
		else if (this is Penguin)
		{
			Penguin penguin = (Penguin)this;
			return penguin.Speak();
		}
		return "sqwak";


	}
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
