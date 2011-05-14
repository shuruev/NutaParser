namespace NutaParser.Lexical.Grammar
{
	public class AvailableIdentifier : ParseExcept
	{
		public static readonly AvailableIdentifier S = new AvailableIdentifier();

		public AvailableIdentifier()
			: base(IdentifierOrKeyword.S, Keyword.S)
		{
		}
	}
}
