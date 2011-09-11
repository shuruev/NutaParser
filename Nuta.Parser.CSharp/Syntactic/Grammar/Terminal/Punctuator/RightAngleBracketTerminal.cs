using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RightAngleBracketTerminal : TextTerminal
	{
		public static readonly RightAngleBracketTerminal S = new RightAngleBracketTerminal();

		public RightAngleBracketTerminal()
			: base(">")
		{
		}
	}
}
