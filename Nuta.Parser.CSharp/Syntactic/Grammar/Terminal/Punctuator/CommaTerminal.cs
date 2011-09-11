using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CommaTerminal : TextTerminal
	{
		public static readonly CommaTerminal S = new CommaTerminal();
		public static readonly Optional O = new Optional(S);

		public CommaTerminal()
			: base(",")
		{
		}
	}
}
