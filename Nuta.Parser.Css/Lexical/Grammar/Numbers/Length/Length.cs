using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Length : ParseAny
	{
		public static readonly Length S = new Length();

		public Length()
			: base(
				LengthPx.S,
				LengthCm.S,
				LengthMm.S,
				LengthIn.S,
				LengthPt.S,
				LengthPc.S)
		{
		}
	}
}
