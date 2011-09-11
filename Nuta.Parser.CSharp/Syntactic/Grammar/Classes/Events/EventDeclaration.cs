using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EventDeclaration : ParseAll
	{
		public static readonly EventDeclaration S = new EventDeclaration();

		public EventDeclaration()
			: base(
				Attributes.O,
				EventModifiers.O,
				EventTerminal.S,
				Type.S,
				new ParseAny(
					new ParseAll(
						VariableDeclarators.S,
						SemicolonTerminal.S),
					new ParseAll(
						MemberName.S,
						LeftCurlyBracketTerminal.S,
						EventAccessorDeclarations.S,
						RightCurlyBracketTerminal.S)))
		{
		}
	}
}
