using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
