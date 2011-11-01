using Nuta.Parser.Syntactic;
using Nuta.Parser.Tests;

namespace Nuta.Parser.Css.Tests.Syntactic
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
			return CssParser.TryParse(item, data);
		}
	}
}
