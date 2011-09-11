using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class HiddenTerminal : LexicalItem
	{
		public static readonly HiddenTerminal S = new HiddenTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "hidden");
		}
	}
}
