using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExplicitTerminal : TextTerminal
	{
		public static readonly ExplicitTerminal S = new ExplicitTerminal();

		public ExplicitTerminal()
			: base("explicit")
		{
		}
	}
}
