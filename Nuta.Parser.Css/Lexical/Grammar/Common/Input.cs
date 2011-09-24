using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Input : ParseAll
	{
		public static readonly Input S = new Input();

		public Input()
			: base(InputElements.O)
		{
		}
	}
}
