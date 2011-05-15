namespace NutaParser.Lexical.Grammar
{
	public class NullLiteral : ParseAll
	{
		public static readonly NullLiteral S = new NullLiteral();

		public NullLiteral()
			: base(NullTerminal.S)
		{
		}
	}
}
