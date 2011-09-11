using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceModifiers : ParseMany
	{
		public static readonly InterfaceModifiers S = new InterfaceModifiers();
		public static readonly Optional O = new Optional(S);

		public InterfaceModifiers()
			: base(InterfaceModifier.S)
		{
		}
	}
}
