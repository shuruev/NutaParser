using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExplicitAnonymousFunctionParameterList : ParseMany
	{
		public static readonly ExplicitAnonymousFunctionParameterList S = new ExplicitAnonymousFunctionParameterList();
		public static readonly Optional O = new Optional(S);

		public ExplicitAnonymousFunctionParameterList()
			: base(ExplicitAnonymousFunctionParameter.S, CommaTerminal.S)
		{
		}
	}
}
