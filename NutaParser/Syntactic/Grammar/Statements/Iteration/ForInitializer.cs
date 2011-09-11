using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ForInitializer : ParseAny
	{
		public static readonly ForInitializer S = new ForInitializer();
		public static readonly Optional O = new Optional(S);

		public ForInitializer()
			: base(
				LocalVariableDeclaration.S,
				StatementExpressionList.S)
		{
		}
	}
}
