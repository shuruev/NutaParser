using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
