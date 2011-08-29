namespace NutaParser.Syntactic.Grammar
{
	public class LocalVariableInitializer : ParseAny
	{
		public static readonly LocalVariableInitializer S = new LocalVariableInitializer();

		public LocalVariableInitializer()
			: base(
				ArrayInitializer.S,
				Expression.S)
		{
		}
	}
}
