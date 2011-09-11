using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CaretTerminal : TextTerminal
	{
		public static readonly CaretTerminal S = new CaretTerminal();

		public CaretTerminal()
			: base("^")
		{
		}
	}
}
