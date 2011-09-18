using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class TimeMs : ParseAll
	{
		public static readonly TimeMs S = new TimeMs();

		public TimeMs()
			: base(
				Number.S,
				LetterM.S,
				LetterS.S)
		{
		}
	}
}
