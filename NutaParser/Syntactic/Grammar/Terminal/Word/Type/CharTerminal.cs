using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class CharTerminal : TextTerminal
	{
		public static readonly CharTerminal S = new CharTerminal();

		public CharTerminal()
			: base("char")
		{
		}
	}
}
