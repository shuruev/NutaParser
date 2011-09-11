using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstantModifiers : ParseMany
	{
		public static readonly ConstantModifiers S = new ConstantModifiers();
		public static readonly Optional O = new Optional(S);

		public ConstantModifiers()
			: base(ConstantModifier.S)
		{
		}
	}
}
