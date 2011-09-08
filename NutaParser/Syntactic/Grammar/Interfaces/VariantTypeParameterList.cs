namespace NutaParser.Syntactic.Grammar
{
	public class VariantTypeParameterList : ParseAll
	{
		public static readonly VariantTypeParameterList S = new VariantTypeParameterList();
		public static readonly Optional O = new Optional(S);

		public VariantTypeParameterList()
			: base(
				LeftAngleBracketTerminal.S,
				VariantTypeParameters.S,
				RightAngleBracketTerminal.S)
		{
		}
	}
}
