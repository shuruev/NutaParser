using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ElementAccess : ParseAll
	{
		public static readonly ElementAccess S = new ElementAccess();

		public ElementAccess()
			: base(
				PrimaryNoArrayCreationExpressionSimple.S,
				new ParseMany(
					new ParseAll(
						PrimaryExpressionSuffixesNotElementAccess.O,
						PrimaryExpressionSuffixElementAccess.S)))
		{
		}
	}
}
