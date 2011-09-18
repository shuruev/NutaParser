using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthIn : ParseAll
	{
		public static readonly LengthIn S = new LengthIn();

		public LengthIn()
			: base(
				Number.S,
				LetterI.S,
				LetterN.S)
		{
		}
	}
}
