using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Size : ParseAny
	{
		public static readonly Size S = new Size();

		public Size()
			: base(
				SizeEm.S,
				SizeEx.S)
		{
		}
	}
}
