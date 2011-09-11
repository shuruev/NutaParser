using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeofTerminal : TextTerminal
	{
		public static readonly TypeofTerminal S = new TypeofTerminal();

		public TypeofTerminal()
			: base("typeof")
		{
		}
	}
}
