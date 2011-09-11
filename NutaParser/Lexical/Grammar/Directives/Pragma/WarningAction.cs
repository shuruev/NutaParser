using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class WarningAction : ParseAny
	{
		public static readonly WarningAction S = new WarningAction();

		public WarningAction()
			: base(
				DisableTerminal.S,
				RestoreTerminal.S)
		{
		}
	}
}
