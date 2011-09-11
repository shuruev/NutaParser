using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DelegateModifiers : ParseMany
	{
		public static readonly DelegateModifiers S = new DelegateModifiers();
		public static readonly Optional O = new Optional(S);

		public DelegateModifiers()
			: base(DelegateModifier.S)
		{
		}
	}
}
