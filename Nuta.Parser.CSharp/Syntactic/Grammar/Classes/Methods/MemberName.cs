using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
