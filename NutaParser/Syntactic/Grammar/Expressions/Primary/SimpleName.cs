namespace NutaParser.Syntactic.Grammar
{
	public class SimpleName : ParseAll
	{
		public static readonly SimpleName S = new SimpleName();

		public SimpleName()
			: base(
				IdentifierTerminal.S,
				TypeArgumentList.O)
		{
		}
	}
}
