using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Dimension : ParseAll
	{
		public static readonly Dimension S = new Dimension();

		public Dimension()
			: base(
				Number.S,
				Identifier.S)
		{
		}
	}
}
