using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NumericLiteral : ParseAny
	{
		public static readonly NumericLiteral S = new NumericLiteral();

		public NumericLiteral()
			: base(
				Percentage.S,
				Length.S,
				Size.S,
				Angle.S,
				Time.S,
				Freq.S,
				Resolution.S,
				Dimension.S,
				Number.S)
		{
		}
	}
}
