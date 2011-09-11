using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DimSeparators : ParseMany
	{
		public static readonly DimSeparators S = new DimSeparators();
		public static readonly Optional O = new Optional(S);

		public DimSeparators()
			: base(CommaTerminal.S)
		{
		}
	}
}
