namespace NutaParser.Syntactic.Grammar
{
	public class AttributeSection : ParseAll
	{
		public static readonly AttributeSection S = new AttributeSection();

		public AttributeSection()
			: base(
				LeftSquareBracketTerminal.S,
				AttributeTargetSpecifier.O,
				AttributeList.S,
				CommaTerminal.O,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
