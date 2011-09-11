using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
