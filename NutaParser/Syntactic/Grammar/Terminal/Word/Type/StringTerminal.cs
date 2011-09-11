using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class StringTerminal : TextTerminal
	{
		public static readonly StringTerminal S = new StringTerminal();

		public StringTerminal()
			: base("string")
		{
		}
	}
}
