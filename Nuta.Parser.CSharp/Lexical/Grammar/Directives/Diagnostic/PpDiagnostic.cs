using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpDiagnostic : ParseAll
	{
		public static readonly PpDiagnostic S = new PpDiagnostic();

		public PpDiagnostic()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				new ParseAny(ErrorTerminal.S, WarningTerminal.S),
				PpMessage.S)
		{
		}
	}
}
