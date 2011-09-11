using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExplicitAnonymousFunctionParameter : ParseAll
	{
		public static readonly ExplicitAnonymousFunctionParameter S = new ExplicitAnonymousFunctionParameter();

		public ExplicitAnonymousFunctionParameter()
			: base(
				AnonymousFunctionParameterModifier.O,
				Type.S,
				IdentifierTerminal.S)
		{
		}
	}
}
