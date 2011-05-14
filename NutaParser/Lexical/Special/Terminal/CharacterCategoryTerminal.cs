using System;
using System.Linq;
using System.Globalization;

namespace NutaParser.Lexical
{
	/// <summary>
	/// Parses any Unicode character from specified categories.
	/// </summary>
	public class CharacterCategoryTerminal : LexicalItem
	{
		private readonly UnicodeCategory[] m_categories;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public CharacterCategoryTerminal(params UnicodeCategory[] categories)
		{
			m_categories = categories;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, Check);
		}

		/// <summary>
		/// Checks whether specified character is suitable for parsing.
		/// </summary>
		private bool Check(char c)
		{
			UnicodeCategory category = Char.GetUnicodeCategory(c);
			return m_categories.Contains(category);
		}
	}
}
