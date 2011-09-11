using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AmpersandTerminal : TextTerminal
	{
		public static readonly AmpersandTerminal S = new AmpersandTerminal();

		public AmpersandTerminal()
			: base("&")
		{
		}
	}
}
