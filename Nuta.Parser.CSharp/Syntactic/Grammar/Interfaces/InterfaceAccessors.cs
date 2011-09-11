using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceAccessors : ParseAny
	{
		public static readonly InterfaceAccessors S = new InterfaceAccessors();

		public InterfaceAccessors()
			: base(
				new ParseAll(
					Attributes.O,
					GetTerminal.S,
					SemicolonTerminal.S,
					Attributes.O,
					SetTerminal.S,
					SemicolonTerminal.S),
				new ParseAll(
					Attributes.O,
					SetTerminal.S,
					SemicolonTerminal.S,
					Attributes.O,
					GetTerminal.S,
					SemicolonTerminal.S),
				new ParseAll(
					Attributes.O,
					GetTerminal.S,
					SemicolonTerminal.S),
				new ParseAll(
					Attributes.O,
					SetTerminal.S,
					SemicolonTerminal.S))
		{
		}
	}
}
