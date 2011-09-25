using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Term : ParseAll
	{
		public static readonly Term S = new Term();

		public Term()
			: base(
				UnaryOperator.O,
				new ParseAny(
					TermPart.S,
					HexColor.S,
					Function.S))
		{
		}
	}
}
