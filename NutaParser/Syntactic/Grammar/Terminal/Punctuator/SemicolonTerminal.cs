using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SemicolonTerminal : TextTerminal
	{
		public static readonly SemicolonTerminal S = new SemicolonTerminal();
		public static readonly Optional O = new Optional(S);

		public SemicolonTerminal()
			: base(";")
		{
		}
	}
}
