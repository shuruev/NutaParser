using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RightShiftAssignmentTerminal : SyntacticItem
	{
		public static readonly RightShiftAssignmentTerminal S = new RightShiftAssignmentTerminal();

		public override bool Parse(SyntacticState state)
		{
			// this terminal consists of two lexical punctuators
			// and should be parsed in a special way
			if (state.InnerPosition + 1 >= state.InnerLength)
				return false;

			LexicalEntry e1 = state.GetInner(state.InnerPosition);
			if (state.GetOuter(e1) != ">")
				return false;

			LexicalEntry e2 = state.GetInner(state.InnerPosition + 1);
			if (state.GetOuter(e2) != ">=")
				return false;

			if (e2.StartPosition != e1.StartPosition + 1)
				return false;

			state.AddAbsolute(
				Key,
				state.InnerPosition + 2,
				state.OuterPosition + 3);

			return true;
		}
	}
}
