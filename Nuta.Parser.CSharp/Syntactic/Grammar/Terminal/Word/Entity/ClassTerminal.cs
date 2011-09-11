using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ClassTerminal : TextTerminal
	{
		public static readonly ClassTerminal S = new ClassTerminal();

		public ClassTerminal()
			: base("class")
		{
		}
	}
}
