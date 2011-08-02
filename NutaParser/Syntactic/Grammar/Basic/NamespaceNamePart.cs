namespace NutaParser.Syntactic.Grammar
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
