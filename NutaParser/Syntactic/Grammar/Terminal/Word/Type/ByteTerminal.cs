namespace NutaParser.Syntactic.Grammar
{
	public class ByteTerminal : TextTerminal
	{
		public static readonly ByteTerminal S = new ByteTerminal();

		public ByteTerminal()
			: base("byte")
		{
		}
	}
}
