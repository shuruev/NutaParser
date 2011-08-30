namespace NutaParser.Syntactic.Grammar
{
	public class OperatorModifiers : ParseMany
	{
		public static readonly OperatorModifiers S = new OperatorModifiers();

		public OperatorModifiers()
			: base(OperatorModifier.S)
		{
		}
	}
}
