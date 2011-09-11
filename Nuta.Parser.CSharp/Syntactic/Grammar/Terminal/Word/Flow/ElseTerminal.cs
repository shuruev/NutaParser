using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ElseTerminal : TextTerminal
	{
		public static readonly ElseTerminal S = new ElseTerminal();

		public ElseTerminal()
			: base("else")
		{
		}
	}
}
