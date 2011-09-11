using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GetTerminal : TextTerminal
	{
		public static readonly GetTerminal S = new GetTerminal();

		public GetTerminal()
			: base("get")
		{
		}
	}
}
