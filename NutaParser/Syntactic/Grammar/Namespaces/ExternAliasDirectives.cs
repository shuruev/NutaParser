namespace NutaParser.Syntactic.Grammar
{
	public class ExternAliasDirectives : ParseMany
	{
		public static readonly ExternAliasDirectives S = new ExternAliasDirectives();
		public static readonly Optional O = new Optional(S);

		public ExternAliasDirectives()
			: base(ExternAliasDirective.S)
		{
		}
	}
}
