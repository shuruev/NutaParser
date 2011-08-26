namespace NutaParser.Syntactic.Grammar
{
	public class Statement : ParseAny
	{
		public static readonly Statement S = new Statement();

		public Statement()
			: base(
				/*xxx*/
				EmbeddedStatement.S)
		{
		}
	}
}
