using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
