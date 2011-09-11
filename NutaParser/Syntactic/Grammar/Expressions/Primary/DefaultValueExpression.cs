using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
