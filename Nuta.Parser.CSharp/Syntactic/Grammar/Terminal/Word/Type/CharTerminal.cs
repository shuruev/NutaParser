using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CharTerminal : TextTerminal
	{
		public static readonly CharTerminal S = new CharTerminal();

		public CharTerminal()
			: base("char")
		{
		}
	}
}
