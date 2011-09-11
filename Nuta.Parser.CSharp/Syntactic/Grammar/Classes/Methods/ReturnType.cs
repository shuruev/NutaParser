using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
