namespace NutaParser.Lexical
{
	/// <summary>
	/// Lexical item containing a batch of similar lexical items with specified delimiter.
	/// </summary>
	public class ParseMany : LexicalItem
	{
		private readonly LexicalItem m_part;
		private readonly LexicalItem m_delimiter;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseMany(LexicalItem part, LexicalItem delimiter)
		{
			m_part = part;
			m_delimiter = delimiter;
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseMany(LexicalItem part)
			: this(part, null)
		{
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, m_part, m_delimiter);
		}
	}
}
