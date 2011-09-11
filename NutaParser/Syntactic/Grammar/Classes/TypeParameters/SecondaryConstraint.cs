using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SecondaryConstraint : ParseAny
	{
		public static readonly SecondaryConstraint S = new SecondaryConstraint();

		public SecondaryConstraint()
			: base(
				InterfaceType.S,
				TypeParameter.S)
		{
		}
	}
}
