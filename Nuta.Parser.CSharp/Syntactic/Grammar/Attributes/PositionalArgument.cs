using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PositionalArgument : ParseAll
	{
		public static readonly PositionalArgument S = new PositionalArgument();

		public PositionalArgument()
			: base(
				ArgumentName.O,
				AttributeArgumentExpression.S)
		{
		}
	}
}
