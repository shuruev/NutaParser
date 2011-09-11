using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
