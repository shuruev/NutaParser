using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ShiftExpression : ParseMany
	{
		public static readonly ShiftExpression S = new ShiftExpression();

		public ShiftExpression()
			: base(
				AdditiveExpression.S,
				new ParseAny(
					LeftShiftTerminal.S,
					RightShiftTerminal.S))
		{
		}
	}
}
