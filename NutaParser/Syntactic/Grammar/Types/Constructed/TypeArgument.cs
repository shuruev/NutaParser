using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeArgument : ParseAny
	{
		public static readonly TypeArgument S = new TypeArgument();

		public TypeArgument()
			: base(Type.S)
		{
		}
	}
}
