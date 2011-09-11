using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StaticConstructorModifiers : ParseAny
	{
		public static readonly StaticConstructorModifiers S = new StaticConstructorModifiers();

		public StaticConstructorModifiers()
			: base(
				new ParseAll(ExternTerminal.S, StaticTerminal.S),
				new ParseAll(StaticTerminal.S, ExternTerminal.S),
				StaticTerminal.S)
		{
		}
	}
}
