using System;

namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Lexical item containing single character specified by function.
	/// </summary>
	public class ParseCharacter : LexicalItem
	{
		private readonly Func<char, bool> m_check;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseCharacter(Func<char, bool> check)
		{
			m_check = check;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, m_check);
		}
	}
}
