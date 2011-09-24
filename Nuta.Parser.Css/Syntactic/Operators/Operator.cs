using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Operator : ParseAll
	{
		public static readonly Operator S = new Operator();

		public Operator()
			: base(
				new ParseAny(
					SlashTerminal.S,
					CommaTerminal.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
