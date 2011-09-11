using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
