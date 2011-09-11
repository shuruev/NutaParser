using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ImplicitAnonymousFunctionParameter : ParseAll
	{
		public static readonly ImplicitAnonymousFunctionParameter S = new ImplicitAnonymousFunctionParameter();

		public ImplicitAnonymousFunctionParameter()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
