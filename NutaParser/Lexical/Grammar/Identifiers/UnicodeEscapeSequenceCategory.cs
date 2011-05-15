using System;
using System.Collections.Generic;
using System.Globalization;

namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeSequenceCategory : LexicalItem
	{
		private readonly HashSet<UnicodeCategory> m_categories;

		public UnicodeEscapeSequenceCategory(params UnicodeCategory[] categories)
		{
			m_categories = new HashSet<UnicodeCategory>(categories);
		}

		public override bool Parse(LexicalState state)
		{
			int index = state.Position;

			if (!UnicodeEscapeSequence.S.Parse(state))
				return false;

			string sequence = state.Get(UnicodeEscapeSequence.S.Key, index);
			char c = (char)Convert.ToInt32(sequence.Substring(2), 16);

			if (!m_categories.Contains(Char.GetUnicodeCategory(c)))
			{
				state.Reset(index);
				return false;
			}

			state.AddBack(Key, index);
			return true;
		}
	}
}
