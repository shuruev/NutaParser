using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ArrayInitializer : SyntacticItem
	{
		public static readonly ArrayInitializer S = new ArrayInitializer();
		public static readonly Optional O = new Optional(S);

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					VariableInitializerList.O,
					RightCurlyBracketTerminal.S),
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					VariableInitializerList.S,
					CommaTerminal.S,
					RightCurlyBracketTerminal.S));
		}
	}
}
