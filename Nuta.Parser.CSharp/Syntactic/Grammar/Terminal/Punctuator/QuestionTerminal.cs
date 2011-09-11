using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
