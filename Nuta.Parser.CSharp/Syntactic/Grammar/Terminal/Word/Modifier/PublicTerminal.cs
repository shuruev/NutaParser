using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PublicTerminal : TextTerminal
	{
		public static readonly PublicTerminal S = new PublicTerminal();

		public PublicTerminal()
			: base("public")
		{
		}
	}
}
