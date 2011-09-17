using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String2Characters : ParseMany
	{
		public static readonly String2Characters S = new String2Characters();
		public static readonly Optional O = new Optional(S);

		public String2Characters()
			: base(String2Character.S)
		{
		}
	}
}
