using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class NotEqualOperatorTerminal : LexicalItem
	{
		public static readonly NotEqualOperatorTerminal S = new NotEqualOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "!=");
		}
	}
}
