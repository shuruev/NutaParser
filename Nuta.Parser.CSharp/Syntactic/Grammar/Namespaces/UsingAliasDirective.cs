using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UsingAliasDirective : ParseAll
	{
		public static readonly UsingAliasDirective S = new UsingAliasDirective();

		public UsingAliasDirective()
			: base(
				UsingTerminal.S,
				IdentifierTerminal.S,
				EqualTerminal.S,
				TypeName.S,
				SemicolonTerminal.S)
		{
		}
	}
}
