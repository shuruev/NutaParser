using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AndExpression : ParseMany
	{
		public static readonly AndExpression S = new AndExpression();

		public AndExpression()
			: base(
				EqualityExpression.S,
				AmpersandTerminal.S)
		{
		}
	}
}
