using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ByteTerminal : TextTerminal
	{
		public static readonly ByteTerminal S = new ByteTerminal();

		public ByteTerminal()
			: base("byte")
		{
		}
	}
}
