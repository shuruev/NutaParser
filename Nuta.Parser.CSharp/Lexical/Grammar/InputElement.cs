using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class InputElement : ParseAny
	{
		public static readonly InputElement S = new InputElement();

		public InputElement()
			: base(
				Whitespace.S,
				Comment.S,
				Token.S)
		{
		}
	}
}
