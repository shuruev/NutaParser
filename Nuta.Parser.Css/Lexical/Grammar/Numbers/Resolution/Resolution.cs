using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Resolution : ParseAny
	{
		public static readonly Resolution S = new Resolution();

		public Resolution()
			: base(
				ResolutionDpi.S,
				ResolutionDpcm.S)
		{
		}
	}
}
