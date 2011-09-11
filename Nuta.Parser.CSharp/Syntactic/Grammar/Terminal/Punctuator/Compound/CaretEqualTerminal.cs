using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CaretEqualTerminal : TextTerminal
	{
		public static readonly CaretEqualTerminal S = new CaretEqualTerminal();

		public CaretEqualTerminal()
			: base("^=")
		{
		}
	}
}
