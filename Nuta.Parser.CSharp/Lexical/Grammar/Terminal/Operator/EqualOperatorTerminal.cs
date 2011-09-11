using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class EqualOperatorTerminal : LexicalItem
	{
		public static readonly EqualOperatorTerminal S = new EqualOperatorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "==");
		}
	}
}
