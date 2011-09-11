using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeParameter : ParseAny
	{
		public static readonly TypeParameter S = new TypeParameter();

		public TypeParameter()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
