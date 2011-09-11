using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrimaryExpression : ParseAny
	{
		public static readonly PrimaryExpression S = new PrimaryExpression();

		public PrimaryExpression()
			: base(
				PrimaryNoArrayCreationExpression.S,
				ArrayCreationExpression.S)
		{
		}
	}
}
