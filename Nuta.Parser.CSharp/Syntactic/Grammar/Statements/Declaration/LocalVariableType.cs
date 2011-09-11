using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
