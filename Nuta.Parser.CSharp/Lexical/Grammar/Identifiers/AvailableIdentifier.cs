using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
