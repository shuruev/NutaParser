using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
