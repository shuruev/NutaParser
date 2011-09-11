using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
