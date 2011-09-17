using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String1Characters : ParseMany
	{
		public static readonly String1Characters S = new String1Characters();
		public static readonly Optional O = new Optional(S);

		public String1Characters()
			: base(String1Character.S)
		{
		}
	}
}
