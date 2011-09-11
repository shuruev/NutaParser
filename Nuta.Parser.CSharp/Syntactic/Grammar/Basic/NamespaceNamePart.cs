using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceNamePart : ParseAll
	{
		public static readonly NamespaceNamePart S = new NamespaceNamePart();

		public NamespaceNamePart()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
