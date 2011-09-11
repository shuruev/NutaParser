using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StructTerminal : TextTerminal
	{
		public static readonly StructTerminal S = new StructTerminal();

		public StructTerminal()
			: base("struct")
		{
		}
	}
}
