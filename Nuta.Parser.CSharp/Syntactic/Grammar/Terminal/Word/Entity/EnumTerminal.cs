using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumTerminal : TextTerminal
	{
		public static readonly EnumTerminal S = new EnumTerminal();

		public EnumTerminal()
			: base("enum")
		{
		}
	}
}
