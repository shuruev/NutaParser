namespace NutaParser.Syntactic.Grammar
{
	public class TypeParameterConstraints : ParseAny
	{
		public static readonly TypeParameterConstraints S = new TypeParameterConstraints();

		public TypeParameterConstraints()
			: base(
				new ParseAll(PrimaryConstraint.S, SecondaryConstraints.S, ConstructorConstraint.S),
				new ParseAll(PrimaryConstraint.S, SecondaryConstraints.S),
				new ParseAll(PrimaryConstraint.S, ConstructorConstraint.S),
				new ParseAll(SecondaryConstraints.S, ConstructorConstraint.S),
				PrimaryConstraint.S,
				SecondaryConstraints.S,
				ConstructorConstraint.S)
		{
		}
	}
}
