using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DelegateModifier : ParseAny
	{
		public static readonly DelegateModifier S = new DelegateModifier();

		public DelegateModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S)
		{
		}
	}
}
