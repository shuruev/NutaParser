using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LeftAngleBracketTerminal : TextTerminal
	{
		public static readonly LeftAngleBracketTerminal S = new LeftAngleBracketTerminal();

		public LeftAngleBracketTerminal()
			: base("<")
		{
		}
	}
}
