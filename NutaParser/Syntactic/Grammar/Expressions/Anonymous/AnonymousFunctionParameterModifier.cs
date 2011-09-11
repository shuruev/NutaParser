using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AnonymousFunctionParameterModifier : ParseAny
	{
		public static readonly AnonymousFunctionParameterModifier S = new AnonymousFunctionParameterModifier();
		public static readonly Optional O = new Optional(S);

		public AnonymousFunctionParameterModifier()
			: base(
				RefTerminal.S,
				OutTerminal.S)
		{
		}
	}
}
