using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
