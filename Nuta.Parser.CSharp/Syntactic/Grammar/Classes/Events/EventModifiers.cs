using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EventModifiers : ParseMany
	{
		public static readonly EventModifiers S = new EventModifiers();
		public static readonly Optional O = new Optional(S);

		public EventModifiers()
			: base(EventModifier.S)
		{
		}
	}
}
