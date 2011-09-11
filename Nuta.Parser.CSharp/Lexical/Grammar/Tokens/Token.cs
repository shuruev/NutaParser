using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class Token : LexicalItem
	{
		public static readonly Token S = new Token();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				Identifier.S,
				Literal.S,
				Keyword.S,
				OperatorOrPunctuator.S);
		}
	}
}
