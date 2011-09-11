using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class OrOperatorTerminal : LexicalItem
	{
		public static readonly OrOperatorTerminal S = new OrOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "||");
		}
	}
}
