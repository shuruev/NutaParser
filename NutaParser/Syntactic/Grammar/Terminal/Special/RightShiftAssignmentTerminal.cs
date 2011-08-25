using System;

namespace NutaParser.Syntactic.Grammar
{
	public class RightShiftAssignmentTerminal : SyntacticItem
	{
		public static readonly RightShiftAssignmentTerminal S = new RightShiftAssignmentTerminal();

		public override bool Parse(SyntacticState state)
		{
			throw new NotImplementedException();
		}
	}
}
