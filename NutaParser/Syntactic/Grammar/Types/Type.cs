namespace NutaParser.Syntactic.Grammar
{
	public class Type : SyntacticItem
	{
		public static readonly Type S = new Type();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				TypePart.S,
				QuestionTerminal.O,
				RankSpecifiers.O);
		}
	}
}
