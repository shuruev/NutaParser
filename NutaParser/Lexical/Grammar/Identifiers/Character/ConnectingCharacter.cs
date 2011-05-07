namespace NutaParser.Lexical.Grammar
{
	public class ConnectingCharacter : LexicalItem
	{
		public static readonly ConnectingCharacter S = new ConnectingCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				ConnectingCharacter1.S,
				ConnectingCharacter2.S);
		}
	}
}
