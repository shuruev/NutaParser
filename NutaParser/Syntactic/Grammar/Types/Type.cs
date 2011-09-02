namespace NutaParser.Syntactic.Grammar
{
	public class Type : SyntacticItem
	{
		public static readonly Type S = new Type();

		public override bool Parse(SyntacticState state)
		{
			if (state.CheckFlag(StateFlags.IgnoreNullable))
			{
				return ParseAll(
					state,
					TypePart.S,
					RankSpecifiers.O);
			}

			return ParseAll(
				state,
				TypePart.S,
				QuestionTerminal.O,
				RankSpecifiers.O);
		}
	}
}
