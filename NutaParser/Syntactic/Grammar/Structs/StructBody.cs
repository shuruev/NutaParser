namespace NutaParser.Syntactic.Grammar
{
	public class StructBody : ParseAll
	{
		public static readonly StructBody S = new StructBody();

		public StructBody()
			: base(
				LeftCurlyBracketTerminal.S,
				StructMemberDeclarations.O,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
