using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PragmaBody : ParseAny
	{
		public static readonly PragmaBody S = new PragmaBody();

		public PragmaBody()
			: base(
				PragmaWarningBody.S,
				PragmaChecksumBody.S)
		{
		}
	}
}
