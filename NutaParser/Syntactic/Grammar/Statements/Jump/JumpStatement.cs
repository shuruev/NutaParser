namespace NutaParser.Syntactic.Grammar
{
	public class JumpStatement : ParseAny
	{
		public static readonly JumpStatement S = new JumpStatement();

		public JumpStatement()
			: base(
				/*xxx*/
				ReturnStatement.S
				/*xxx*/)
		{
		}
	}
}
