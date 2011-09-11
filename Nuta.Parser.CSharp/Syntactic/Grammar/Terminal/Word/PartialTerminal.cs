using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PartialTerminal : TextTerminal
	{
		public static readonly PartialTerminal S = new PartialTerminal();
		public static readonly Optional O = new Optional(S);

		public PartialTerminal()
			: base("partial")
		{
		}
	}
}
