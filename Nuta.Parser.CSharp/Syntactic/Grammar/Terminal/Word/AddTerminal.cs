using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AddTerminal : TextTerminal
	{
		public static readonly AddTerminal S = new AddTerminal();

		public AddTerminal()
			: base("add")
		{
		}
	}
}
