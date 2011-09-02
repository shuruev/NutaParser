using System;
using NutaParser.Lexical;
using NutaParser.Lexical.Grammar;

namespace NutaParser.Syntactic.Grammar
{
	public class IdentifierInLinqTerminal : SyntacticItem
	{
		public static readonly IdentifierInLinqTerminal S = new IdentifierInLinqTerminal();

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			if (state.IsEndOfData)
				return false;

			LexicalEntry entry = state.GetInner(state.InnerPosition);
			if (entry.Key != Identifier.S.Key)
				return false;

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
