using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ClassModifier : ParseAny
	{
		public static readonly ClassModifier S = new ClassModifier();

		public ClassModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				AbstractTerminal.S,
				SealedTerminal.S,
				StaticTerminal.S)
		{
		}
	}
}
