using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeArguments : ParseMany
	{
		public static readonly TypeArguments S = new TypeArguments();

		public TypeArguments()
			: base(TypeArgument.S, CommaTerminal.S)
		{
		}
	}
}
