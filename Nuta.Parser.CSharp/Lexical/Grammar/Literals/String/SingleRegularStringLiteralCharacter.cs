using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class SingleRegularStringLiteralCharacter : ParseExcept
	{
		public static readonly SingleRegularStringLiteralCharacter S = new SingleRegularStringLiteralCharacter();

		public SingleRegularStringLiteralCharacter()
			: base(
				AnyCharacterTerminal.S,
				new ParseAny(QuoteTerminal.S, BackslashTerminal.S, NewLineCharacter.S))
		{
		}
	}
}
