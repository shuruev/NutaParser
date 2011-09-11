using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpRegion : ParseAll
	{
		public static readonly PpRegion S = new PpRegion();

		public PpRegion()
			: base(PpStartRegion.S, ConditionalSection.O, PpEndRegion.S)
		{
		}
	}
}
