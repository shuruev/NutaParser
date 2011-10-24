using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQuery : ParseAll
	{
		public static readonly MediaQuery S = new MediaQuery();

		public MediaQuery()
			: base(
				new ParseAny(
					MediaQueryPrefix1.S,
					MediaQueryPrefix2.S),
				MediaQuerySuffixes.O)
		{
		}
	}
}
