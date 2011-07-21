namespace NutaParser.Syntactic
{
	/// <summary>
	/// Syntactic item containing a batch of similar syntactic items with specified delimiter.
	/// </summary>
	public class ParseMany : SyntacticItem
	{
		private readonly SyntacticItem m_part;
		private readonly SyntacticItem m_delimiter;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseMany(SyntacticItem part, SyntacticItem delimiter)
		{
			m_part = part;
			m_delimiter = delimiter;
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseMany(SyntacticItem part)
			: this(part, null)
		{
		}

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			return ParseMany(state, m_part, m_delimiter);
		}
	}
}
