using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ObjectTerminal : TextTerminal
	{
		public static readonly ObjectTerminal S = new ObjectTerminal();

		public ObjectTerminal()
			: base("object")
		{
		}
	}
}
