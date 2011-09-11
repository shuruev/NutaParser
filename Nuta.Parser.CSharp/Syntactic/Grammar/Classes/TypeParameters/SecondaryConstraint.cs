using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
