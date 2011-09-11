using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ExternAliasDirective : ParseAll
	{
		public static readonly ExternAliasDirective S = new ExternAliasDirective();

		public ExternAliasDirective()
			: base(
				ExternTerminal.S,
				AliasTerminal.S,
				IdentifierTerminal.S,
				SemicolonTerminal.S)
		{
		}
	}
}
