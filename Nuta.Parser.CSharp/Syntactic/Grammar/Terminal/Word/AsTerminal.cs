using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AsTerminal : TextTerminal
	{
		public static readonly AsTerminal S = new AsTerminal();

		public AsTerminal()
			: base("as")
		{
		}
	}
}
