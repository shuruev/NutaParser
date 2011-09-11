using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MinusTerminal : TextTerminal
	{
		public static readonly MinusTerminal S = new MinusTerminal();

		public MinusTerminal()
			: base("-")
		{
		}
	}
}
