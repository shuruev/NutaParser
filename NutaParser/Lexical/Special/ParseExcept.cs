namespace NutaParser.Lexical
{
	/// <summary>
	/// Lexical item containing all specified items except some others.
	/// </summary>
	public class ParseExcept : LexicalItem
	{
		private readonly LexicalItem m_main;
		private readonly LexicalItem m_exception;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseExcept(LexicalItem main, LexicalItem exception)
		{
			m_main = main;
			m_exception = exception;
		}

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseExcept(state, m_main, m_exception);
		}
	}
}
