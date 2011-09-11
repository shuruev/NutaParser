using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ReturnType : ParseAny
	{
		public static readonly ReturnType S = new ReturnType();

		public ReturnType()
			: base(
				VoidTerminal.S,
				Type.S)
		{
		}
	}
}
