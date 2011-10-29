using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Operator : ParseAll
	{
		public static readonly Operator S = new Operator();
		public static readonly Optional O = new Optional(S);

		public Operator()
			: base(
				new ParseAny(
					SlashTerminal.S,
					CommaTerminal.S),
				Whitespaces.O)
		{
		}
	}
}
