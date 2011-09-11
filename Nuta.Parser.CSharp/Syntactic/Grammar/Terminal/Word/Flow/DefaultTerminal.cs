using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DefaultTerminal : TextTerminal
	{
		public static readonly DefaultTerminal S = new DefaultTerminal();

		public DefaultTerminal()
			: base("default")
		{
		}
	}
}
