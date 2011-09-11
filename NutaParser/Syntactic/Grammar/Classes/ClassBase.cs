using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ClassBase : ParseAll
	{
		public static readonly ClassBase S = new ClassBase();
		public static readonly Optional O = new Optional(S);

		public ClassBase()
			: base(
				ColonTerminal.S,
				new ParseAny(
					new ParseAll(ClassType.S, CommaTerminal.S, InterfaceTypeList.S),
					InterfaceTypeList.S,
					ClassType.S))
		{
		}
	}
}
