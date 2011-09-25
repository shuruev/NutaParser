using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Expression : ParseMany
	{
		public static readonly Expression S = new Expression();

		public Expression()
			: base(Term.S, Operator.O)
		{
		}
	}
}
