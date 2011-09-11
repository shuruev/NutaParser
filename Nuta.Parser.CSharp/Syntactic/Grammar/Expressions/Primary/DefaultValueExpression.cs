using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DefaultValueExpression : ParseAll
	{
		public static readonly DefaultValueExpression S = new DefaultValueExpression();

		public DefaultValueExpression()
			: base(
				DefaultTerminal.S,
				LeftRoundBracketTerminal.S,
				Type.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
