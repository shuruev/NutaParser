using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SelectionStatement : ParseAny
	{
		public static readonly SelectionStatement S = new SelectionStatement();

		public SelectionStatement()
			: base(
				IfStatement.S,
				SwitchStatement.S)
		{
		}
	}
}
