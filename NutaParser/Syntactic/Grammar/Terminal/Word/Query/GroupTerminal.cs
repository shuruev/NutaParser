using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class GroupTerminal : TextTerminal
	{
		public static readonly GroupTerminal S = new GroupTerminal();

		public GroupTerminal()
			: base("group")
		{
		}
	}
}
