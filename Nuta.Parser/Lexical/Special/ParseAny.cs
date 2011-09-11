namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Lexical item containing any of specified lexical items.
	/// </summary>
	public class ParseAny : LexicalItem
	{
		private readonly LexicalItem[] m_items;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseAny(params LexicalItem[] items)
		{
			m_items = items;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseAny(state, m_items);
		}
	}
}
