using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class RealTypeSuffix : SingleCharacterTerminal
	{
		public static readonly RealTypeSuffix S = new RealTypeSuffix();
		public static readonly Optional O = new Optional(S);

		public RealTypeSuffix()
			: base('F', 'f', 'D', 'd', 'M', 'm')
		{
		}
	}
}
