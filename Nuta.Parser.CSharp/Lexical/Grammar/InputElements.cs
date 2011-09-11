using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class InputElements : ParseMany
	{
		public static readonly InputElements S = new InputElements();
		public static readonly Optional O = new Optional(S);

		public InputElements()
			: base(InputElement.S)
		{
		}
	}
}
