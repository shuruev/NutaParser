using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InterfaceTypeList : ParseMany
	{
		public static readonly InterfaceTypeList S = new InterfaceTypeList();

		public InterfaceTypeList()
			: base(InterfaceType.S, CommaTerminal.S)
		{
		}
	}
}
