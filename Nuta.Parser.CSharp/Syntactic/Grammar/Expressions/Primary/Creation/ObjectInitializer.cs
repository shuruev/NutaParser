using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ObjectInitializer : ParseAny
	{
		public static readonly ObjectInitializer S = new ObjectInitializer();

		public ObjectInitializer()
			: base(
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					MemberInitializerList.O,
					RightCurlyBracketTerminal.S),
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					MemberInitializerList.S,
					CommaTerminal.S,
					RightCurlyBracketTerminal.S))
		{
		}
	}
}
