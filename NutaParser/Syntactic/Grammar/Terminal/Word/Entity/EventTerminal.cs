using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
