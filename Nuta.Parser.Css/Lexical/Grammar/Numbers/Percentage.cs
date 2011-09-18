using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Percentage : ParseAll
	{
		public static readonly Percentage S = new Percentage();

		public Percentage()
			: base(
				Number.S,
				PercentTerminal.S)
		{
		}
	}
}
