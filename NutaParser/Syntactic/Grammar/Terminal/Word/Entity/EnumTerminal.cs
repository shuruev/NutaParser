using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class EnumTerminal : TextTerminal
	{
		public static readonly EnumTerminal S = new EnumTerminal();

		public EnumTerminal()
			: base("enum")
		{
		}
	}
}
