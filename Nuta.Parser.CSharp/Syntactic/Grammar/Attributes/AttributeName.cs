using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AttributeName : ParseAll
	{
		public static readonly AttributeName S = new AttributeName();

		public AttributeName()
			: base(TypeName.S)
		{
		}
	}
}
