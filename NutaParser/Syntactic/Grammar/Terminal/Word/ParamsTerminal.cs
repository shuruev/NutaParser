namespace NutaParser.Syntactic.Grammar
{
	public class ParamsTerminal : TextTerminal
	{
		public static readonly ParamsTerminal S = new ParamsTerminal();

		public ParamsTerminal()
			: base("params")
		{
		}
	}
}
