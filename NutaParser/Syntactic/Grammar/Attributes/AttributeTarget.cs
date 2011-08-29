namespace NutaParser.Syntactic.Grammar
{
	public class AttributeTarget : ParseAny
	{
		public static readonly AttributeTarget S = new AttributeTarget();

		public AttributeTarget()
			: base(
				FieldTerminal.S,
				EventTerminal.S,
				MethodTerminal.S,
				ParamTerminal.S,
				PropertyTerminal.S,
				ReturnTerminal.S,
				TypeTerminal.S)
		{
		}
	}
}
