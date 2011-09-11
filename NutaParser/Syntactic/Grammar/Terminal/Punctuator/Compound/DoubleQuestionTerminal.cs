using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DoubleQuestionTerminal : TextTerminal
	{
		public static readonly DoubleQuestionTerminal S = new DoubleQuestionTerminal();

		public DoubleQuestionTerminal()
			: base("??")
		{
		}
	}
}
