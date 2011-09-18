namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Lexical item containing any of specified words.
	/// </summary>
	public class ParseWord : LexicalItem
	{
		private readonly bool m_ignoreCase;
		private readonly string[] m_words;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseWord(params string[] words)
			: this(false, words)
		{
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseWord(bool ignoreCase, params string[] words)
		{
			m_ignoreCase = ignoreCase;
			m_words = words;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, m_ignoreCase, m_words);
		}
	}
}
