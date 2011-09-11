using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class Orderings : ParseMany
	{
		public static readonly Orderings S = new Orderings();

		public Orderings()
			: base(Ordering.S, CommaTerminal.S)
		{
		}
	}
}
