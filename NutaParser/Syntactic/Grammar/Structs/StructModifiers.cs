namespace NutaParser.Syntactic.Grammar
{
	public class StructModifiers : ParseMany
	{
		public static readonly StructModifiers S = new StructModifiers();
		public static readonly Optional O = new Optional(S);

		public StructModifiers()
			: base(StructModifier.S)
		{
		}
	}
}
