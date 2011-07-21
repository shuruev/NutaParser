namespace NutaParser.Syntactic.Grammar
{
	public class QuestionTerminal : TextTerminal
	{
		public static readonly QuestionTerminal S = new QuestionTerminal();

		public QuestionTerminal()
			: base("?")
		{
		}
	}
}
