using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeParameters : ParseMany
	{
		public static readonly TypeParameters S = new TypeParameters();

		public TypeParameters()
			: base(
				new ParseAll(Attributes.O, TypeParameter.S),
				CommaTerminal.S)
		{
		}
	}
}
