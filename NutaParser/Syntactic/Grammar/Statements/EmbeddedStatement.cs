namespace NutaParser.Syntactic.Grammar
{
	public class EmbeddedStatement : ParseAny
	{
		public static readonly EmbeddedStatement S = new EmbeddedStatement();

		public EmbeddedStatement()
			: base(
				Block.S,
				EmptyStatement.S,
				ExpressionStatement.S,
				/*xxx*/
				JumpStatement.S
				/*xxx*/)
		{
		}
	}
}
