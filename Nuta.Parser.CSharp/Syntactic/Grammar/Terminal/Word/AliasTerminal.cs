using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AliasTerminal : TextTerminal
	{
		public static readonly AliasTerminal S = new AliasTerminal();

		public AliasTerminal()
			: base("alias")
		{
		}
	}
}
