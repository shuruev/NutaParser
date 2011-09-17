using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Name : ParseMany
	{
		public static readonly Name S = new Name();
		public static readonly Optional O = new Optional(S);

		public Name()
			: base(NameCharacter.S)
		{
		}
	}
}
