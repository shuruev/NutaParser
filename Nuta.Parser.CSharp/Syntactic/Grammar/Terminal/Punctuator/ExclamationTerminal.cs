using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExclamationTerminal : TextTerminal
	{
		public static readonly ExclamationTerminal S = new ExclamationTerminal();

		public ExclamationTerminal()
			: base("!")
		{
		}
	}
}
