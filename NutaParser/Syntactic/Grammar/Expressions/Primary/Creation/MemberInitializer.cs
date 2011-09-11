using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class MemberInitializer : ParseAll
	{
		public static readonly MemberInitializer S = new MemberInitializer();

		public MemberInitializer()
			: base(
				IdentifierTerminal.S,
				EqualTerminal.S,
				InitializerValue.S)
		{
		}
	}
}
