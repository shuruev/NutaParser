namespace NutaParser.Syntactic.Grammar
{
	public class BaseTerminal : TextTerminal
	{
		public static readonly BaseTerminal S = new BaseTerminal();

		public BaseTerminal()
			: base("base")
		{
		}
	}
}
