using System;
using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Css.Syntactic;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css
{
	/// <summary>
	/// Contains some useful and service methods.
	/// </summary>
	public static class CssParser
	{
		/// <summary>
		/// Tries to parse specified data as a syntactic item.
		/// </summary>
		public static bool TryParse(SyntacticItem item, string data)
		{
			LexicalState lexicalState = new LexicalState(data);
			if (!Input.S.ParseFull(lexicalState))
				return false;

			SyntacticState syntacticState = new SyntacticState(
				lexicalState.ExtractTokens(),
				data);

			if (!item.ParseFull(syntacticState))
				return false;

			return true;
		}

		/// <summary>
		/// Ensures that specified data could be parsed as a syntactic item.
		/// </summary>
		public static void Ensure(SyntacticItem item, string data)
		{
			if (!TryParse(item, data))
				throw new InvalidOperationException();
		}

		/// <summary>
		/// Ensures that specified data could be parsed.
		/// </summary>
		public static void Ensure(string data)
		{
			if (!TryParse(Stylesheet.S, data))
				throw new InvalidOperationException();
		}
	}
}
