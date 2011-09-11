using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class FormFeedTerminal : SingleCharacterTerminal
	{
		public static readonly FormFeedTerminal S = new FormFeedTerminal();

		public FormFeedTerminal()
			: base('\x000C')
		{
		}
	}
}
