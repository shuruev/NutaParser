using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ForCondition : ParseAll
	{
		public static readonly ForCondition S = new ForCondition();
		public static readonly Optional O = new Optional(S);

		public ForCondition()
			: base(BooleanExpression.S)
		{
		}
	}
}
