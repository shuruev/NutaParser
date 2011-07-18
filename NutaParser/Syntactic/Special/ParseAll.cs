namespace NutaParser.Syntactic
{
	/// <summary>
	/// Syntactic item containing consequent number of specified syntactic items.
	/// </summary>
	public class ParseAll : SyntacticItem
	{
		private readonly SyntacticItem[] m_items;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseAll(params SyntacticItem[] items)
		{
			m_items = items;
		}

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			return ParseAll(state, m_items);
		}
	}
}
