using Nuta.Parser.Lexical;
using Nuta.Parser.Tests;

namespace Nuta.Parser.Css.Tests.Lexical
{
	/// <summary>
	/// Provides service methods for testing lexical analysis.
	/// </summary>
	public class LexicalTest : LexicalTestBase
	{
		/// <summary>
		/// Tries to parses specified data string into lexical item.
		/// </summary>
		protected override bool Parse(LexicalItem item, string data)
		{
			LexicalState state = new LexicalState(data);
			return item.ParseFull(state);
		}
	}
}
