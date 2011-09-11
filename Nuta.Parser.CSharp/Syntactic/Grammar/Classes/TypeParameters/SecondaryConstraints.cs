using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
