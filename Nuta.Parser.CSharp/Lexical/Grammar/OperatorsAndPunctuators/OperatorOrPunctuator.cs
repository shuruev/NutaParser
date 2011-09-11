using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class OperatorOrPunctuator : LexicalItem
	{
		public static readonly OperatorOrPunctuator S = new OperatorOrPunctuator();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"<<=",
				"??",
				"::",
				"++",
				"--",
				"&&",
				"||",
				"->",
				"==",
				"!=",
				"<=",
				">=",
				"+=",
				"-=",
				"*=",
				"/=",
				"%=",
				"&=",
				"|=",
				"^=",
				"<<",
				"=>",
				"{",
				"}",
				"[",
				"]",
				"(",
				")",
				".",
				",",
				":",
				";",
				"+",
				"-",
				"*",
				"/",
				"%",
				"&",
				"|",
				"^",
				"!",
				"~",
				"=",
				"<",
				">",
				"?");
		}
	}
}
