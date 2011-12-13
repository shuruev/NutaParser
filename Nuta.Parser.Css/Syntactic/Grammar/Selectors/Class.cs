using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Class : ParseAll
	{
		public static readonly Class S = new Class();

		public Class()
			: base(
				PeriodTerminal.S,
				IdentifierTerminal.S)
		{
		}
	}
}
