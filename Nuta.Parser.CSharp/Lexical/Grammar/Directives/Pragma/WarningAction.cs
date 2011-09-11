using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
