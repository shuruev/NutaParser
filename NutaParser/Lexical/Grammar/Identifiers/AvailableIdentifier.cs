namespace NutaParser.Lexical.Grammar
{
	public class AvailableIdentifier : LexicalItem
	{
		public static readonly AvailableIdentifier S = new AvailableIdentifier();

		public override bool Parse(LexicalState state)
		{
			int index = state.Position;

			if (!IdentifierOrKeyword.S.Parse(state))
				return false;

			string identifier = state.Get(IdentifierOrKeyword.S.Key, index);

			LexicalState check = new LexicalState(identifier);
			if (Keyword.S.Parse(check))
			{
				if (check.IsEndOfFile)
				{
					state.Reset(index);
					return false;
				}
			}

			return true;
		}
	}
}
