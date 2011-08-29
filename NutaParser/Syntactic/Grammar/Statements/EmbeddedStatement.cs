namespace NutaParser.Syntactic.Grammar
{
	public class EmbeddedStatement : SyntacticItem
	{
		public static readonly EmbeddedStatement S = new EmbeddedStatement();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				Block.S,
				EmptyStatement.S,
				ExpressionStatement.S,
				SelectionStatement.S,
				IterationStatement.S,
				JumpStatement.S
				/*xxx*/);
		}
	}
}
