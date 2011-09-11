using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpDeclaration : ParseAll
	{
		public static readonly PpDeclaration S = new PpDeclaration();

		public PpDeclaration()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				new ParseAny(DefineTerminal.S, UndefTerminal.S),
				Whitespace.S,
				ConditionalSymbol.S,
				PpNewLine.S)
		{
		}
	}
}
