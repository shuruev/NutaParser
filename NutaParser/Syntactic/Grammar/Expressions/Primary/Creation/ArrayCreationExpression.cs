using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ArrayCreationExpression : ParseAny
	{
		public static readonly ArrayCreationExpression S = new ArrayCreationExpression();

		public ArrayCreationExpression()
			: base(
				new ParseAll(
					NewTerminal.S,
					Type.S,
					LeftSquareBracketTerminal.S,
					ExpressionList.S,
					RightSquareBracketTerminal.S,
					RankSpecifiers.O,
					ArrayInitializer.O),
				new ParseAll(
					NewTerminal.S,
					ArrayType.S,
					ArrayInitializer.S),
				new ParseAll(
					NewTerminal.S,
					RankSpecifier.S,
					ArrayInitializer.S))
		{
		}
	}
}
