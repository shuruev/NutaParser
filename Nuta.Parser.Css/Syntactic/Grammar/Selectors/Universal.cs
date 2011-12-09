using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Universal : ParseAll
	{
		public static readonly Universal S = new Universal();

		public Universal()
			: base(
				NamespacePrefix.O,
				AsteriskTerminal.S)
		{
		}
	}
}
