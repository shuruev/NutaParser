using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoubleAmpersandTerminal : TextTerminal
	{
		public static readonly DoubleAmpersandTerminal S = new DoubleAmpersandTerminal();

		public DoubleAmpersandTerminal()
			: base("&&")
		{
		}
	}
}
