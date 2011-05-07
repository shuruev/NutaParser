namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral : LexicalItem
	{
		public static readonly RealLiteral S = new RealLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				RealLiteral1.S,
				RealLiteral2.S,
				RealLiteral3.S,
				RealLiteral4.S,
				RealLiteral5.S,
				RealLiteral6.S,
				RealLiteral7.S,
				RealLiteral8.S,
				RealLiteral9.S,
				RealLiteral10.S,
				RealLiteral11.S);
		}
	}
}
