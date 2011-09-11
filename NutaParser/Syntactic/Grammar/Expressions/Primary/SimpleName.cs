using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SimpleName : SyntacticItem
	{
		public static readonly SimpleName S = new SimpleName();

		public override bool Parse(SyntacticState state)
		{
			// in some cases we might need to prohibit
			// using LINQ keywords as identifiers
			if (state.CheckFlag(StateFlags.InsideLinq))
			{
				return ParseAll(
					state,
					IdentifierInLinqTerminal.S,
					TypeArgumentList.O);
			}

			return ParseAll(
				state,
				IdentifierTerminal.S,
				TypeArgumentList.O);
		}
	}
}
