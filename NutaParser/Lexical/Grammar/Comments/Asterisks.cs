using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class Asterisks : ParseMany
	{
		public static readonly Asterisks S = new Asterisks();
		public static readonly Optional O = new Optional(S);

		public Asterisks()
			: base(AsteriskTerminal.S)
		{
		}
	}
}
