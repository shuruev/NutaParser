using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class SingleVerbatimStringLiteralCharacter : ParseExcept
	{
		public static readonly SingleVerbatimStringLiteralCharacter S = new SingleVerbatimStringLiteralCharacter();

		public SingleVerbatimStringLiteralCharacter()
			: base(AnyCharacterTerminal.S, QuoteTerminal.S)
		{
		}
	}
}
