namespace NutaParser.Syntactic.Grammar
{
	public class ConversionOperatorDeclarator : ParseAll
	{
		public static readonly ConversionOperatorDeclarator S = new ConversionOperatorDeclarator();

		public ConversionOperatorDeclarator()
			: base(
				new ParseAny(ImplicitTerminal.S, ExplicitTerminal.S),
				OperatorTerminal.S,
				Type.S,
				LeftRoundBracketTerminal.S,
				Type.S,
				IdentifierTerminal.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
