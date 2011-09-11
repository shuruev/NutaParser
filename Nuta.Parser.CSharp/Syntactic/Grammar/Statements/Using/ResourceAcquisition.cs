using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ResourceAcquisition : ParseAny
	{
		public static readonly ResourceAcquisition S = new ResourceAcquisition();

		public ResourceAcquisition()
			: base(
				LocalVariableDeclaration.S,
				Expression.S)
		{
		}
	}
}
