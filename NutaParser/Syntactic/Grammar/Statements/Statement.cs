namespace NutaParser.Syntactic.Grammar
{
	public class Statement : ParseAny
	{
		public static readonly Statement S = new Statement();

		public Statement()
			: base(
				LabeledStatement.S,
				DeclarationStatement.S,
				EmbeddedStatement.S)
		{
		}
	}
}
