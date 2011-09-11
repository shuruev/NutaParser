using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class ChecksumTerminal : LexicalItem
	{
		public static readonly ChecksumTerminal S = new ChecksumTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "checksum");
		}
	}
}
