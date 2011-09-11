using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class EndregionTerminal : LexicalItem
	{
		public static readonly EndregionTerminal S = new EndregionTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "endregion");
		}
	}
}
