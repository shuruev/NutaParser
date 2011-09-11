using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class Input : ParseAll
	{
		public static readonly Input S = new Input();

		public Input()
			: base(InputSection.O)
		{
		}
	}
}
