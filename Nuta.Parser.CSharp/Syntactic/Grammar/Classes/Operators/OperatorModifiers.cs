using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
