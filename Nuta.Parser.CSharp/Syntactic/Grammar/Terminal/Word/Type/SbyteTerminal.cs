using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SbyteTerminal : TextTerminal
	{
		public static readonly SbyteTerminal S = new SbyteTerminal();

		public SbyteTerminal()
			: base("sbyte")
		{
		}
	}
}
