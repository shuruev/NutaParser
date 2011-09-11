using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceBody : ParseAll
	{
		public static readonly InterfaceBody S = new InterfaceBody();

		public InterfaceBody()
			: base(
				LeftCurlyBracketTerminal.S,
				InterfaceMemberDeclarations.O,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
