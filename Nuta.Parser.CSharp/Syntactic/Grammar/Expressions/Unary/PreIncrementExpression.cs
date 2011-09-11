using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PreIncrementExpression : ParseAll
	{
		public static readonly PreIncrementExpression S = new PreIncrementExpression();

		public PreIncrementExpression()
			: base(
				DoublePlusTerminal.S,
				UnaryExpression.S)
		{
		}
	}
}
