using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FloatTerminal : TextTerminal
	{
		public static readonly FloatTerminal S = new FloatTerminal();

		public FloatTerminal()
			: base("float")
		{
		}
	}
}
