using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ArgumentName : ParseAll
	{
		public static readonly ArgumentName S = new ArgumentName();
		public static readonly Optional O = new Optional(S);

		public ArgumentName()
			: base(
				IdentifierTerminal.S,
				ColonTerminal.S)
		{
		}
	}
}
