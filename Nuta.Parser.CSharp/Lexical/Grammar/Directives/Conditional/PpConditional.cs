using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
