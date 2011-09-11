using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ParamTerminal : TextTerminal
	{
		public static readonly ParamTerminal S = new ParamTerminal();

		public ParamTerminal()
			: base("param")
		{
		}
	}
}
