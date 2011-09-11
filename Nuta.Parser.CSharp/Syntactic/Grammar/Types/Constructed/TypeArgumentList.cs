using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
