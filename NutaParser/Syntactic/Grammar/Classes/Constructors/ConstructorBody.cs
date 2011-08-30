namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorBody : ParseAny
	{
		public static readonly ConstructorBody S = new ConstructorBody();

		public ConstructorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
