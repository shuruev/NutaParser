using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InterfaceType : ParseAny
	{
		public static readonly InterfaceType S = new InterfaceType();

		public InterfaceType()
			: base(TypeName.S)
		{
		}
	}
}
