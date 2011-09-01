namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryConstraint : ParseAny
	{
		public static readonly PrimaryConstraint S = new PrimaryConstraint();

		public PrimaryConstraint()
			: base(
				ClassTerminal.S,
				StructTerminal.S,
				ClassType.S)
		{
		}
	}
}
