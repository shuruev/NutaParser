using System.Collections.Generic;
using System.Linq;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	/// <summary>
	/// Specific lexical machine methods.
	/// </summary>
	public static class LexicalStateExtensions
	{
		/// <summary>
		/// Extracts all tokens from parsed result.
		/// </summary>
		public static List<LexicalEntry> ExtractTokens(this LexicalState state)
		{
			return state
				.GetAllEntries()
				.Where(entry =>
					entry.Key == Identifier.S.Key
					|| entry.Key == Whitespace.S.Key
					|| entry.Key == Hash.S.Key
					|| entry.Key == FunctionPrefix.S.Key)
					//xxx more tokens here
				.ToList();
		}
	}
}
