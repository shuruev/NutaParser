namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorModifiers : ParseMany
	{
		public static readonly ConstructorModifiers S = new ConstructorModifiers();
		public static readonly Optional O = new Optional(S);

		public ConstructorModifiers()
			: base(ConstructorModifier.S)
		{
		}
	}
}
