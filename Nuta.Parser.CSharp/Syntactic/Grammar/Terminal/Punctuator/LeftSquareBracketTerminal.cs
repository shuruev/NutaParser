using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LeftSquareBracketTerminal : TextTerminal
	{
		public static readonly LeftSquareBracketTerminal S = new LeftSquareBracketTerminal();

		public LeftSquareBracketTerminal()
			: base("[")
		{
		}
	}
}
