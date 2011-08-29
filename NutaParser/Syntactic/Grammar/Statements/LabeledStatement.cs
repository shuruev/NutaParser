namespace NutaParser.Syntactic.Grammar
{
	public class LabeledStatement : ParseAll
	{
		public static readonly LabeledStatement S = new LabeledStatement();

		public LabeledStatement()
			: base(
				IdentifierTerminal.S,
				ColonTerminal.S,
				Statement.S)
		{
		}
	}
}
