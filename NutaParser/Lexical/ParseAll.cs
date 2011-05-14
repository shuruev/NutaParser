namespace NutaParser.Lexical
{
	/// <summary>
	/// Lexical item containing consequent number of specified lexical items.
	/// </summary>
	public class ParseAll : LexicalItem
	{
		private readonly LexicalItem[] m_items;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseAll(params LexicalItem[] items)
		{
			m_items = items;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseAll(state, m_items);
		}
	}
}
