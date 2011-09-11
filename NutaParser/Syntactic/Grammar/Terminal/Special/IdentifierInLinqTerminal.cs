using Nuta.Parser.CSharp.Lexical.Grammar;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class IdentifierInLinqTerminal : SyntacticItem
	{
		public static readonly IdentifierInLinqTerminal S = new IdentifierInLinqTerminal();

		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			LexicalEntry entry = state.GetInner(state.InnerPosition);
			if (entry.Key != Identifier.S.Key)
				return false;

			// parse all identidiers except those
			// which are similar to LINQ keywords
			string name = state.GetOuter(entry);
			if (name == "ascending"
				|| name == "by"
				|| name == "descending"
				|| name == "equals"
				|| name == "from"
				|| name == "group"
				|| name == "in"
				|| name == "into"
				|| name == "join"
				|| name == "let"
				|| name == "on"
				|| name == "orderby"
				|| name == "select"
				|| name == "where")
				return false;

			state.AddAbsolute(
				Key,
				state.InnerPosition + 1,
				entry.EndPosition);

			return true;
		}
	}
}
