using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AttributeTargetSpecifier : ParseAll
	{
		public static readonly AttributeTargetSpecifier S = new AttributeTargetSpecifier();
		public static readonly Optional O = new Optional(S);

		public AttributeTargetSpecifier()
			: base(
				AttributeTarget.S,
				ColonTerminal.S)
		{
		}
	}
}
