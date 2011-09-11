using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class JoinTerminal : TextTerminal
	{
		public static readonly JoinTerminal S = new JoinTerminal();

		public JoinTerminal()
			: base("join")
		{
		}
	}
}
