namespace NutaParser.Syntactic.Grammar
{
	public class ParamTerminal : TextTerminal
	{
		public static readonly ParamTerminal S = new ParamTerminal();

		public ParamTerminal()
			: base("param")
		{
		}
	}
}
