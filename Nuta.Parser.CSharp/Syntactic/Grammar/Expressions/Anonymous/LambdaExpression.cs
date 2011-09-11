using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LambdaExpression : ParseAll
	{
		public static readonly LambdaExpression S = new LambdaExpression();

		public LambdaExpression()
			: base(
				AnonymousFunctionSignature.S,
				ImplicationTerminal.S,
				AnonymousFunctionBody.S)
		{
		}
	}
}
