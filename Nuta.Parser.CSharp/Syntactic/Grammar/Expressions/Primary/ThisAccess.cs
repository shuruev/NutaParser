using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ThisAccess : ParseAll
	{
		public static readonly ThisAccess S = new ThisAccess();

		public ThisAccess()
			: base(ThisTerminal.S)
		{
		}
	}
}
