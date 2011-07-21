namespace NutaParser.Syntactic.Grammar
{
	public class FloatingPointType : ParseAny
	{
		public static readonly FloatingPointType S = new FloatingPointType();

		public FloatingPointType()
			: base(
				FloatTerminal.S,
				DoubleTerminal.S)
		{
		}
	}
}
