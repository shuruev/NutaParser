using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class StructTerminal : TextTerminal
	{
		public static readonly StructTerminal S = new StructTerminal();

		public StructTerminal()
			: base("struct")
		{
		}
	}
}
