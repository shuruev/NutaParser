using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class Commas : ParseMany
	{
		public static readonly Commas S = new Commas();
		public static readonly Optional O = new Optional(S);

		public Commas()
			: base(CommaTerminal.S)
		{
		}
	}
}
