namespace NutaParser.Lexical.Grammar
{
	public class NotNumberSign : LexicalItem
	{
		public static readonly NotNumberSign S = new NotNumberSign();

		public override bool Parse(LexicalState state)
		{
			int index = state.Position;

			if (!InputCharacter.S.Parse(state))
				return false;

			string input = state.Get(InputCharacter.S.Key, index);
			if (input == "#")
			{
				state.Reset(index);
				return false;
			}

			return true;
		}
	}
}
