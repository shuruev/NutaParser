namespace NutaParser.Syntactic.Grammar
{
	public class LeftShiftAssignmentTerminal : TextTerminal
	{
		public static readonly LeftShiftAssignmentTerminal S = new LeftShiftAssignmentTerminal();

		public LeftShiftAssignmentTerminal()
			: base("<<=")
		{
		}
	}
}
