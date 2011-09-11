using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class RegionTerminal : LexicalItem
	{
		public static readonly RegionTerminal S = new RegionTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "region");
		}
	}
}
