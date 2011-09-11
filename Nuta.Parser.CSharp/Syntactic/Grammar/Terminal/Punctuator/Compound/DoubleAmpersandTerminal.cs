using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
