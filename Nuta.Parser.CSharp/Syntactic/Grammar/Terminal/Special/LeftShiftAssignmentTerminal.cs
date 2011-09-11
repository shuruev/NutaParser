using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
