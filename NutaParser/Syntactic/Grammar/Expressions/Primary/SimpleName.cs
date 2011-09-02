namespace NutaParser.Syntactic.Grammar
{
	public class SimpleName : SyntacticItem
	{
		public static readonly SimpleName S = new SimpleName();

		public override bool Parse(SyntacticState state)
		{
			if (state.CheckFlag(StateFlags.InsideLinq))
			{
				return ParseAll(
					state,
					IdentifierInLinqTerminal.S,
					TypeArgumentList.O);
			}

			return ParseAll(
				state,
				IdentifierTerminal.S,
				TypeArgumentList.O);
		}
	}
}
