using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AdditiveExpression : ParseMany
	{
		public static readonly AdditiveExpression S = new AdditiveExpression();

		public AdditiveExpression()
			: base(
				MultiplicativeExpression.S,
				new ParseAny(
					PlusTerminal.S,
					MinusTerminal.S))
		{
		}
	}
}
