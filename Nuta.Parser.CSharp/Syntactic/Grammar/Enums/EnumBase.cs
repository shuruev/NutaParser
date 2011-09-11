using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumBase : ParseAll
	{
		public static readonly EnumBase S = new EnumBase();
		public static readonly Optional O = new Optional(S);

		public EnumBase()
			: base(
				ColonTerminal.S,
				IntegralType.S)
		{
		}
	}
}
