using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class CarriageReturnTerminal : SingleCharacterTerminal
	{
		public static readonly CarriageReturnTerminal S = new CarriageReturnTerminal();

		public CarriageReturnTerminal()
			: base('\x000D')
		{
		}
	}
}
