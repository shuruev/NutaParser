using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Time : ParseAny
	{
		public static readonly Time S = new Time();

		public Time()
			: base(
				TimeMs.S,
				TimeS.S)
		{
		}
	}
}
