using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class RestoreTerminal : LexicalItem
	{
		public static readonly RestoreTerminal S = new RestoreTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "restore");
		}
	}
}
