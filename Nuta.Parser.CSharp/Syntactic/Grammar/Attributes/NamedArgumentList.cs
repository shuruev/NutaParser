using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamedArgumentList : ParseMany
	{
		public static readonly NamedArgumentList S = new NamedArgumentList();

		public NamedArgumentList()
			: base(NamedArgument.S, CommaTerminal.S)
		{
		}
	}
}
