namespace NutaParser.Syntactic.Grammar
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
