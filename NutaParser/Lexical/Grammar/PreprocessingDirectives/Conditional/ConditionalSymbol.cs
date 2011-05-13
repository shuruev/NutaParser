namespace NutaParser.Lexical.Grammar
{
	public class ConditionalSymbol : LexicalItem
	{
		public static readonly ConditionalSymbol S = new ConditionalSymbol();

		public override bool Parse(LexicalState state)
		{
			int index = state.Position;

			if (!IdentifierOrKeyword.S.Parse(state))
				return false;

			string input = state.Get(IdentifierOrKeyword.S.Key, index);
			if (input == "true" || input == "false")
			{
				state.Reset(index);
				return false;
			}

			return true;
		}
	}
}
