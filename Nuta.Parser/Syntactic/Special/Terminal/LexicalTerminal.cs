using Nuta.Parser.Lexical;

namespace Nuta.Parser.Syntactic
{
	/// <summary>
	/// Parses lexical terminal.
	/// </summary>
	public class LexicalTerminal : SyntacticItem
	{
		private readonly LexicalItem m_item;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public LexicalTerminal(LexicalItem item)
		{
			m_item = item;
		}

		/// <summary>
		/// Gets entity key.
		/// </summary>
		public override string Key
		{
			get
			{
				return m_item.Key;
			}
		}

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			LexicalEntry entry = state.GetInner(state.InnerPosition);
			if (entry.Key != m_item.Key)
				return false;

			state.AddAbsolute(
				Key,
				state.InnerPosition + 1,
				entry.EndPosition);

			return true;
		}
	}
}
