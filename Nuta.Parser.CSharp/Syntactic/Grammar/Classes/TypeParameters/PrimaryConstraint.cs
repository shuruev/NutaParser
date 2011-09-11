using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
