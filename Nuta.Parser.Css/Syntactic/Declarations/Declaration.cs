using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Declaration : ParseAll
	{
		public static readonly Declaration S = new Declaration();

		public Declaration()
			: base(
				Property.S,
				ColonTerminal.S,
				WhitespaceTerminal.O,
				Expression.S,
				Priority.O)
		{
		}
	}
}
