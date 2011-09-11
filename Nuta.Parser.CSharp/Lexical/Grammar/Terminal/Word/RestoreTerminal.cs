using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
