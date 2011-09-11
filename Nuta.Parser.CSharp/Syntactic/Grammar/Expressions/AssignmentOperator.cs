using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AssignmentOperator : ParseAny
	{
		public static readonly AssignmentOperator S = new AssignmentOperator();

		public AssignmentOperator()
			: base(
				EqualTerminal.S,
				PlusEqualTerminal.S,
				MinusEqualTerminal.S,
				AsteriskEqualTerminal.S,
				SlashEqualTerminal.S,
				PercentEqualTerminal.S,
				AmpersandEqualTerminal.S,
				BarEqualTerminal.S,
				CaretEqualTerminal.S,
				LeftShiftAssignmentTerminal.S,
				RightShiftAssignmentTerminal.S)
		{
		}
	}
}
