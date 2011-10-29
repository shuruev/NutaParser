using System;
using Nuta.Parser.CSharp.Lexical;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp
{
	/// <summary>
	/// Contains some useful and service methods.
	/// </summary>
	public static class CSharpParser
	{
		/// <summary>
		/// Ensures that specified data could be parsed as syntactic item.
		/// </summary>
		public static void Ensure(SyntacticItem item, string data)
		{
			LexicalState lexicalState = new LexicalState(data);
			if (!Input.S.ParseFull(lexicalState))
				throw new InvalidOperationException();

			SyntacticState syntacticState = new SyntacticState(
				lexicalState.ExtractTokens(),
				data);

			if (!item.ParseFull(syntacticState))
				throw new InvalidOperationException();
		}
	}
}
