using System.Collections.Generic;

namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Parses any of specified character.
	/// </summary>
	public class SingleCharacterTerminal : LexicalItem
	{
		private readonly HashSet<char> m_characters;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public SingleCharacterTerminal(params char[] characters)
		{
			m_characters = new HashSet<char>(characters);
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => m_characters.Contains(c));
		}
	}
}
