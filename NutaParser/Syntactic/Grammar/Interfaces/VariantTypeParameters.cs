namespace NutaParser.Syntactic.Grammar
{
	public class VariantTypeParameters : ParseMany
	{
		public static readonly VariantTypeParameters S = new VariantTypeParameters();

		public VariantTypeParameters()
			: base(
				new ParseAll(
					Attributes.O,
					VarianceAnnotation.O,
					TypeParameter.S),
				CommaTerminal.S)
		{
		}
	}
}
