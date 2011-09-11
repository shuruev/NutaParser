using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GlobalAttributeTargetSpecifier : ParseAll
	{
		public static readonly GlobalAttributeTargetSpecifier S = new GlobalAttributeTargetSpecifier();

		public GlobalAttributeTargetSpecifier()
			: base(
				GlobalAttributeTarget.S,
				ColonTerminal.S)
		{
		}
	}
}
