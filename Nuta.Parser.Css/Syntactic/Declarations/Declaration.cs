using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Declaration : ParseAll
	{
		public static readonly Declaration S = new Declaration();
		public static readonly Optional O = new Optional(S);

		public Declaration()
			: base(
				Property.S,
				ColonTerminal.S,
				Whitespaces.O,
				Expression.S,
				Priority.O)
		{
		}
	}
}
