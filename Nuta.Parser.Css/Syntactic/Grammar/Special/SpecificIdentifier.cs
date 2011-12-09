using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;
using ParseAll = Nuta.Parser.Lexical.ParseAll;

namespace Nuta.Parser.Css.Syntactic
{
	public abstract class SpecificIdentifier : SyntacticItem
	{
		private readonly LexicalItem m_check;

		protected SpecificIdentifier(params LexicalItem[] items)
		{
			m_check = new ParseAll(items);
		}

		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			// ensure that identifier is captured
			LexicalEntry entry = state.GetInner(state.InnerPosition);
			if (entry.Key != Identifier.S.Key)
				return false;

			// check that identifier consists only of specified letters
			string checkOuter = state.GetOuter(entry);
			LexicalState checkState = new LexicalState(checkOuter);
			if (!m_check.ParseFull(checkState))
				return false;

			state.AddAbsolute(
				Key,
				state.InnerPosition + 1,
				entry.EndPosition);

			return true;
		}
	}
}
