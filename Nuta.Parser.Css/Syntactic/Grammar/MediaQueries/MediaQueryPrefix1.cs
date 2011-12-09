using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQueryPrefix1 : ParseAll
	{
		public static readonly MediaQueryPrefix1 S = new MediaQueryPrefix1();

		public MediaQueryPrefix1()
			: base(
				new ParseAny(
					IdentifierOnly.S,
					IdentifierNot.S,
					Empty.S),
				Whitespaces.O,
				MediaType.S,
				Whitespaces.O)
		{
		}
	}
}
