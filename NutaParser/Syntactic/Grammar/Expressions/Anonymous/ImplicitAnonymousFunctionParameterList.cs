namespace NutaParser.Syntactic.Grammar
{
	public class ImplicitAnonymousFunctionParameterList : ParseMany
	{
		public static readonly ImplicitAnonymousFunctionParameterList S = new ImplicitAnonymousFunctionParameterList();
		public static readonly Optional O = new Optional(S);

		public ImplicitAnonymousFunctionParameterList()
			: base(ImplicitAnonymousFunctionParameter.S, CommaTerminal.S)
		{
		}
	}
}
