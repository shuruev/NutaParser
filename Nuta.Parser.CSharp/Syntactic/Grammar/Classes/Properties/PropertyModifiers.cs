using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PropertyModifiers : ParseMany
	{
		public static readonly PropertyModifiers S = new PropertyModifiers();
		public static readonly Optional O = new Optional(S);

		public PropertyModifiers()
			: base(PropertyModifier.S)
		{
		}
	}
}
