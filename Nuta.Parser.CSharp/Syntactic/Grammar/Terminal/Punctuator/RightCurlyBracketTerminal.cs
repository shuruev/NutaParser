using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RightCurlyBracketTerminal : TextTerminal
	{
		public static readonly RightCurlyBracketTerminal S = new RightCurlyBracketTerminal();

		public RightCurlyBracketTerminal()
			: base("}")
		{
		}
	}
}
