using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SizeEx : ParseAll
	{
		public static readonly SizeEx S = new SizeEx();

		public SizeEx()
			: base(
				Number.S,
				LetterE.S,
				LetterX.S)
		{
		}
	}
}
