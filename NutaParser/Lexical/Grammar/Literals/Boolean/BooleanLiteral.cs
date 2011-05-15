namespace NutaParser.Lexical.Grammar
{
	public class BooleanLiteral : ParseAny
	{
		public static readonly BooleanLiteral S = new BooleanLiteral();

		public BooleanLiteral()
			: base(TrueTerminal.S, FalseTerminal.S)
		{
		}
	}
}
