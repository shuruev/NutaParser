using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EventTerminal : TextTerminal
	{
		public static readonly EventTerminal S = new EventTerminal();

		public EventTerminal()
			: base("event")
		{
		}
	}
}
