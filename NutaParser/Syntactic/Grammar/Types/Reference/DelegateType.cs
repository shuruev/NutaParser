using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DelegateType : ParseAny
	{
		public static readonly DelegateType S = new DelegateType();

		public DelegateType()
			: base(TypeName.S)
		{
		}
	}
}
