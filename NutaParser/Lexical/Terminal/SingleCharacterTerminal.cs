namespace NutaParser.Lexical.Grammar
{
	/// <summary>
	/// Parses any Unicode character.
	/// </summary>
	public class SingleCharacterTerminal : LexicalItem
	{
		private readonly char m_character;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public SingleCharacterTerminal(char character)
		{
			m_character = character;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => c == m_character);
		}
	}
}
