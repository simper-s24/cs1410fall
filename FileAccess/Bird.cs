public abstract class Bird
{
	protected string feathers;
	protected string flight;
	public Bird()
	{
		this.feathers = "";
		this.flight = "";
	}

	public virtual string FeatherColor()
	{
		return "Brown";
	}
	public virtual string Speak() {
		return "Sqwak";
	}
}
