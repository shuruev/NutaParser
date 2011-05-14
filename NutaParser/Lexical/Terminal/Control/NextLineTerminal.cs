namespace NutaParser.Lexical.Grammar
{
	public class NextLineTerminal : SingleCharacterTerminal
	{
		public static readonly NextLineTerminal S = new NextLineTerminal();

		public NextLineTerminal()
			: base('\x0085')
		{
		}
	}
}
