using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class LocalVariableType : ParseAny
	{
		public static readonly LocalVariableType S = new LocalVariableType();

		public LocalVariableType()
			: base(
				VarTerminal.S,
				Type.S)
		{
		}
	}
}
