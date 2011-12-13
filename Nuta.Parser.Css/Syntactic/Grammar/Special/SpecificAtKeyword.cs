using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;
using ParseAll = Nuta.Parser.Lexical.ParseAll;

namespace Nuta.Parser.Css.Syntactic
{
	public abstract class SpecificAtKeyword : SyntacticItem
	{
		private readonly LexicalItem m_check;

		protected SpecificAtKeyword(params LexicalItem[] items)
		{
			m_check = new ParseAll(items);
		}

		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			// ensure that at-keyword is captured
			LexicalEntry entry = state.GetInner(state.InnerPosition);
			if (entry.Key != AtKeyword.S.Key)
				return false;

			// check that at-keyword consists only of specified letters
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
