using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQueryPrefix2 : ParseAll
	{
		public static readonly MediaQueryPrefix2 S = new MediaQueryPrefix2();

		public MediaQueryPrefix2()
			: base(MediaExpression.S)
		{
		}
	}
}
