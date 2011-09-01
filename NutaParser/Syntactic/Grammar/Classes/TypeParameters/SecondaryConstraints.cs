namespace NutaParser.Syntactic.Grammar
{
	public class SecondaryConstraints : ParseMany
	{
		public static readonly SecondaryConstraints S = new SecondaryConstraints();

		public SecondaryConstraints()
			: base(SecondaryConstraint.S, CommaTerminal.S)
		{
		}
	}
}
