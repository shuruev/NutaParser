using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ArgumentList : ParseMany
	{
		public static readonly ArgumentList S = new ArgumentList();
		public static readonly Optional O = new Optional(S);

		public ArgumentList()
			: base(Argument.S, CommaTerminal.S)
		{
		}
	}
}
