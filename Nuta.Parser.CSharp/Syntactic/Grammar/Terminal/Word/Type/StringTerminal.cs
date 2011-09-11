using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StringTerminal : TextTerminal
	{
		public static readonly StringTerminal S = new StringTerminal();

		public StringTerminal()
			: base("string")
		{
		}
	}
}
