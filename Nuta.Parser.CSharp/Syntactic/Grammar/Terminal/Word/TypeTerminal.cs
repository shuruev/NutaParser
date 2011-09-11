using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeTerminal : TextTerminal
	{
		public static readonly TypeTerminal S = new TypeTerminal();

		public TypeTerminal()
			: base("type")
		{
		}
	}
}
