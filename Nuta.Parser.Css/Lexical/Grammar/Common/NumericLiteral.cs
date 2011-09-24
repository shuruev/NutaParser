using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NumericLiteral : ParseAny
	{
		public static readonly NumericLiteral S = new NumericLiteral();

		public NumericLiteral()
			: base(
				Size.S,
				Length.S,
				Angle.S,
				Time.S,
				Freq.S,
				Dimension.S,
				Percentage.S,
				Number.S)
		{
		}
	}
}
