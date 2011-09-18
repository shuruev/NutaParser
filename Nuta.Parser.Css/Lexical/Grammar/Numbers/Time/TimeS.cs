using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class TimeS : ParseAll
	{
		public static readonly TimeS S = new TimeS();

		public TimeS()
			: base(
				Number.S,
				LetterS.S)
		{
		}
	}
}
