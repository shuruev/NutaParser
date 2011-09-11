using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OnTerminal : TextTerminal
	{
		public static readonly OnTerminal S = new OnTerminal();

		public OnTerminal()
			: base("on")
		{
		}
	}
}
