using NutaParser.Lexical;

namespace NutaParser.Syntactic
{
	/// <summary>
	/// Parses lexical terminal.
	/// </summary>
	public class LexicalTerminal : SyntacticItem
	{
		private readonly string m_key;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public LexicalTerminal(string key)
		{
			m_key = key;
		}

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			LexicalEntry entry = state.Get(state.InnerPosition);
			if (entry.Key != m_key)
				return false;

			state.AddIncrement(Key, 1, entry.Length);
			return true;
		}
	}
}
