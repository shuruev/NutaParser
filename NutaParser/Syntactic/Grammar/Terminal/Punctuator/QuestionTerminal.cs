using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class QuestionTerminal : TextTerminal
	{
		public static readonly QuestionTerminal S = new QuestionTerminal();
		public static readonly Optional O = new Optional(S);

		public QuestionTerminal()
			: base("?")
		{
		}
	}
}
