using Nuta.Parser.Lexical;

namespace Nuta.Parser.Syntactic
{
	/// <summary>
	/// Parses text terminal.
	/// </summary>
	public class TextTerminal : SyntacticItem
	{
		private readonly string m_text;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public TextTerminal(string text)
		{
			m_text = text;
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
			string text = state.GetOuter(entry);
			if (text != m_text)
				return false;

			state.AddAbsolute(
				Key,
				state.InnerPosition + 1,
				entry.EndPosition);

			return true;
		}
	}
}
