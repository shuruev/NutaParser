using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
