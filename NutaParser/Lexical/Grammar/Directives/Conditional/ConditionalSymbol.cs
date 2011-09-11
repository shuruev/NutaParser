using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class ConditionalSymbol : ParseExcept
	{
		public static readonly ConditionalSymbol S = new ConditionalSymbol();

		public ConditionalSymbol()
			: base(
				IdentifierOrKeyword.S,
				new ParseAny(TrueTerminal.S, FalseTerminal.S))
		{
		}
	}
}
