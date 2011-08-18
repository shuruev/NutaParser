namespace NutaParser.Syntactic.Grammar
{
	public class CollectionInitializer : ParseAll
	{
		public static readonly CollectionInitializer S = new CollectionInitializer();

		public CollectionInitializer()
			: base(
				LeftCurlyBracketTerminal.S,
				ElementInitializerList.S,
				CommaTerminal.O,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
