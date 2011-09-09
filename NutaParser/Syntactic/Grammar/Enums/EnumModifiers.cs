namespace NutaParser.Syntactic.Grammar
{
	public class EnumModifiers : ParseMany
	{
		public static readonly EnumModifiers S = new EnumModifiers();
		public static readonly Optional O = new Optional(S);

		public EnumModifiers()
			: base(EnumModifier.S)
		{
		}
	}
}
