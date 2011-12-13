using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Property : ParseAll
	{
		public static readonly Property S = new Property();

		public Property()
			: base(
				IdentifierTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
