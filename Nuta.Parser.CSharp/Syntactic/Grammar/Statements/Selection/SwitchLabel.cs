using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SwitchLabel : ParseAny
	{
		public static readonly SwitchLabel S = new SwitchLabel();

		public SwitchLabel()
			: base(
				new ParseAll(
					CaseTerminal.S,
					ConstantExpression.S,
					ColonTerminal.S),
				new ParseAll(
					DefaultTerminal.S,
					ColonTerminal.S))
		{
		}
	}
}
