using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
