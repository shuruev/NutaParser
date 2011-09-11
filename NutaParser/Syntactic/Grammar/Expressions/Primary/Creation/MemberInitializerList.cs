using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class MemberInitializerList : ParseMany
	{
		public static readonly MemberInitializerList S = new MemberInitializerList();
		public static readonly Optional O = new Optional(S);

		public MemberInitializerList()
			: base(MemberInitializer.S, CommaTerminal.S)
		{
		}
	}
}
