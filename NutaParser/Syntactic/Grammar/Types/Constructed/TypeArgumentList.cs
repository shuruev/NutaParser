using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeArgumentList : ParseAll
	{
		public static readonly TypeArgumentList S = new TypeArgumentList();
		public static readonly Optional O = new Optional(S);

		public TypeArgumentList()
			: base(
				LeftAngleBracketTerminal.S,
				TypeArguments.S,
				RightAngleBracketTerminal.S)
		{
		}
	}
}
