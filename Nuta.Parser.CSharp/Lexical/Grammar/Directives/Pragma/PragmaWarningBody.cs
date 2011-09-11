using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PragmaWarningBody : ParseAny
	{
		public static readonly PragmaWarningBody S = new PragmaWarningBody();

		public PragmaWarningBody()
			: base(
				new ParseAll(
					WarningTerminal.S,
					Whitespace.S,
					WarningAction.S,
					Whitespace.S,
					WarningList.S),
				new ParseAll(
					WarningTerminal.S,
					Whitespace.S,
					WarningAction.S))
		{
		}
	}
}
