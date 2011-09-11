using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class EndifTerminal : LexicalItem
	{
		public static readonly EndifTerminal S = new EndifTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "endif");
		}
	}
}
