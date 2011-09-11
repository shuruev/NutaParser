using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ClassBody : ParseAll
	{
		public static readonly ClassBody S = new ClassBody();

		public ClassBody()
			: base(
				LeftCurlyBracketTerminal.S,
				ClassMemberDeclarations.O,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
