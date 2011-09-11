using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FieldTerminal : TextTerminal
	{
		public static readonly FieldTerminal S = new FieldTerminal();

		public FieldTerminal()
			: base("field")
		{
		}
	}
}
