using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Angle : ParseAny
	{
		public static readonly Angle S = new Angle();

		public Angle()
			: base(
				AngleDeg.S,
				AngleRad.S,
				AngleGrad.S)
		{
		}
	}
}
