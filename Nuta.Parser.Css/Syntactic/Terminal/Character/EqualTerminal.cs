using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class EqualTerminal : TextTerminal
	{
		public static readonly EqualTerminal S = new EqualTerminal();

		public EqualTerminal()
			: base("=")
		{
		}
	}
}
