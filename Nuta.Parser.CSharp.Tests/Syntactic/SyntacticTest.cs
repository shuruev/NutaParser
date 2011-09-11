using Nuta.Parser.CSharp.Lexical;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;
using Nuta.Parser.Tests;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	/// <summary>
	/// Provides service methods for testing syntactic analysis.
	/// </summary>
	public class SyntacticTest : SyntacticTestBase
	{
		/// <summary>
		/// Tries to parses specified data string into syntactic item.
		/// </summary>
		protected override bool Parse(SyntacticItem item, string data)
		{
			data = Parser.PrepareEndOfFile(data);

			LexicalState lexicalState = new LexicalState(data);
			if (!Input.S.ParseFull(lexicalState))
				return false;

			SyntacticState syntacticState = new SyntacticState(
				lexicalState.ExtractTokens(),
				data);

			return item.ParseFull(syntacticState);
		}
	}
}
