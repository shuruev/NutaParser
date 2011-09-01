namespace NutaParser.Syntactic.Grammar
{
	public class MethodBody : ParseAny
	{
		public static readonly MethodBody S = new MethodBody();

		public MethodBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
