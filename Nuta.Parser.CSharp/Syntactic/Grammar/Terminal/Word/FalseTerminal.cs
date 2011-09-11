using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FalseTerminal : TextTerminal
	{
		public static readonly FalseTerminal S = new FalseTerminal();

		public FalseTerminal()
			: base("false")
		{
		}
	}
}
