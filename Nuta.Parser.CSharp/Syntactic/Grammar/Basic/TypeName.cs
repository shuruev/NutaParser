using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeName : ParseAll
	{
		public static readonly TypeName S = new TypeName();

		public TypeName()
			: base(
				QualifiedAliasPrefix.O,
				new ParseMany(TypeNamePart.S, PeriodTerminal.S))
		{
		}
	}
}
