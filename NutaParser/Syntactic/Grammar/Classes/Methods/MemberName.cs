using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class MemberName : ParseAny
	{
		public static readonly MemberName S = new MemberName();

		public MemberName()
			: base(
				TypeName.S,
				IdentifierTerminal.S)
		{
		}
	}
}
