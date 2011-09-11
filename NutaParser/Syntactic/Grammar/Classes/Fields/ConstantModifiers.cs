using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
