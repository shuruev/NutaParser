using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class Statement : SyntacticItem
	{
		public static readonly Statement S = new Statement();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				LabeledStatement.S,
				DeclarationStatement.S,
				EmbeddedStatement.S);
		}
	}
}
