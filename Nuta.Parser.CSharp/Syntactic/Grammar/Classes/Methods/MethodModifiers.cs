using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MethodModifiers : ParseMany
	{
		public static readonly MethodModifiers S = new MethodModifiers();
		public static readonly Optional O = new Optional(S);

		public MethodModifiers()
			: base(MethodModifier.S)
		{
		}
	}
}
