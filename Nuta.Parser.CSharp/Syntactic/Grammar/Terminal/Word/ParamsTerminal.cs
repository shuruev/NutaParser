using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ParamsTerminal : TextTerminal
	{
		public static readonly ParamsTerminal S = new ParamsTerminal();

		public ParamsTerminal()
			: base("params")
		{
		}
	}
}
