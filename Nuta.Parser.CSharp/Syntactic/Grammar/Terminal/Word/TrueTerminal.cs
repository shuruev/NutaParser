using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TrueTerminal : TextTerminal
	{
		public static readonly TrueTerminal S = new TrueTerminal();

		public TrueTerminal()
			: base("true")
		{
		}
	}
}
