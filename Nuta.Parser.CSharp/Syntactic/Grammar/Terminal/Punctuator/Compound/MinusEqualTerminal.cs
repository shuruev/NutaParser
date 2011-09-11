using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MinusEqualTerminal : TextTerminal
	{
		public static readonly MinusEqualTerminal S = new MinusEqualTerminal();

		public MinusEqualTerminal()
			: base("-=")
		{
		}
	}
}
