namespace NutaParser.Syntactic.Grammar
{
	public class VariableDeclarator : ParseAny
	{
		public static readonly VariableDeclarator S = new VariableDeclarator();

		public VariableDeclarator()
			: base(
				new ParseAll(
					IdentifierTerminal.S,
					EqualTerminal.S,
					VariableInitializer.S),
				IdentifierTerminal.S)
		{
		}
	}
}
