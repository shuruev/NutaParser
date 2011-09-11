using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AnonymousFunctionSignature : ParseAny
	{
		public static readonly AnonymousFunctionSignature S = new AnonymousFunctionSignature();

		public AnonymousFunctionSignature()
			: base(
				ExplicitAnonymousFunctionSignature.S,
				ImplicitAnonymousFunctionSignature.S)
		{
		}
	}
}
