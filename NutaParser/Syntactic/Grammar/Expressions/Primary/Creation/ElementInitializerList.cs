using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ElementInitializerList : ParseMany
	{
		public static readonly ElementInitializerList S = new ElementInitializerList();

		public ElementInitializerList()
			: base(ElementInitializer.S, CommaTerminal.S)
		{
		}
	}
}
