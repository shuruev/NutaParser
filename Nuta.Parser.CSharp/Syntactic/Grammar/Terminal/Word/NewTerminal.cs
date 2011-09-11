using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NewTerminal : TextTerminal
	{
		public static readonly NewTerminal S = new NewTerminal();
		public static readonly Optional O = new Optional(S);

		public NewTerminal()
			: base("new")
		{
		}
	}
}
