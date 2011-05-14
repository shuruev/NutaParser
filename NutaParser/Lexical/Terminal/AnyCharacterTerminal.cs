namespace NutaParser.Lexical.Grammar
{
	/// <summary>
	/// Parses any Unicode character.
	/// </summary>
	public class AnyCharacterTerminal : LexicalItem
	{
		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => true);
		}
	}
}
