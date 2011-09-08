namespace NutaParser.Syntactic.Grammar
{
	public class VarianceAnnotation : ParseAny
	{
		public static readonly VarianceAnnotation S = new VarianceAnnotation();
		public static readonly Optional O = new Optional(S);

		public VarianceAnnotation()
			: base(
				InTerminal.S,
				OutTerminal.S)
		{
		}
	}
}
