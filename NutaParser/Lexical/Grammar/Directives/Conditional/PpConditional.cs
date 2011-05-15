namespace NutaParser.Lexical.Grammar
{
	public class PpConditional : ParseAll
	{
		public static readonly PpConditional S = new PpConditional();

		public PpConditional()
			: base(
				PpIfSection.S,
				PpElifSections.O,
				PpElseSection.O,
				PpEndif.S)
		{
		}
	}
}
