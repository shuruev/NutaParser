namespace NutaParser.Syntactic.Grammar
{
	public class ArgumentList : ParseMany
	{
		public static readonly ArgumentList S = new ArgumentList();

		public ArgumentList()
			: base(Argument.S, CommaTerminal.S)
		{
		}
	}
}
