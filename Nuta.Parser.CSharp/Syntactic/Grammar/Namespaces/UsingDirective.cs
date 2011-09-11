using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UsingDirective : ParseAny
	{
		public static readonly UsingDirective S = new UsingDirective();

		public UsingDirective()
			: base(
				UsingAliasDirective.S,
				UsingNamespaceDirective.S)
		{
		}
	}
}
