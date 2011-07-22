namespace NutaParser.Syntactic.Grammar
{
	public class ObjectTerminal : TextTerminal
	{
		public static readonly ObjectTerminal S = new ObjectTerminal();

		public ObjectTerminal()
			: base("object")
		{
		}
	}
}
