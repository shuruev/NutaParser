using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
