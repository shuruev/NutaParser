using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class GenericDimensionSpecifier : ParseAll
	{
		public static readonly GenericDimensionSpecifier S = new GenericDimensionSpecifier();
		public static readonly Optional O = new Optional(S);

		public GenericDimensionSpecifier()
			: base(
				LeftAngleBracketTerminal.S,
				Commas.O,
				RightAngleBracketTerminal.S)
		{
		}
	}
}
