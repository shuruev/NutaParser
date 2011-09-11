using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpElifSection : ParseAll
	{
		public static readonly PpElifSection S = new PpElifSection();

		public PpElifSection()
			: base(
				Whitespace.O,
				NumberSignTerminal.S,
				Whitespace.O,
				ElifTerminal.S,
				Whitespace.S,
				PpExpression.S,
				PpNewLine.S,
				ConditionalSection.O)
		{
		}
	}
}
