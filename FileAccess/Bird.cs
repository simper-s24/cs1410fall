public abstract class Bird
{
	protected string feathers;
	protected string flight;

	public string Test { get; private set; }
	internal string Test2 {  get; protected set; }
	protected string Test3 {  get; internal set; }

	public Bird()
	{
		this.feathers = "";
		this.flight = "";
	}

	public virtual string FeatherColor()
	{
		return "Brown";
	}
	public virtual string Speak()
	{
		return "Sqwak";
	}
}
