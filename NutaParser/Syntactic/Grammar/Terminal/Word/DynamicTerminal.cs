namespace NutaParser.Syntactic.Grammar
{
	public class DynamicTerminal : TextTerminal
	{
		public static readonly DynamicTerminal S = new DynamicTerminal();

		public DynamicTerminal()
			: base("dynamic")
		{
		}
	}
}
