namespace Nuta.Parser.Syntactic
{
	/// <summary>
	/// Syntactic item containing any of specified syntactic items.
	/// </summary>
	public class ParseAny : SyntacticItem
	{
		private readonly SyntacticItem[] m_items;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ParseAny(params SyntacticItem[] items)
		{
			m_items = items;
		}

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			return ParseAny(state, m_items);
		}
	}
}
