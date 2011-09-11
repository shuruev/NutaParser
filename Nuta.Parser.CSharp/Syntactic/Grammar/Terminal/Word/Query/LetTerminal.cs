using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LetTerminal : TextTerminal
	{
		public static readonly LetTerminal S = new LetTerminal();

		public LetTerminal()
			: base("let")
		{
		}
	}
}
