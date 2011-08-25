﻿namespace NutaParser.Syntactic.Grammar
{
	public class UnboundTypeName : ParseAll
	{
		public static readonly UnboundTypeName S = new UnboundTypeName();

		public UnboundTypeName()
			: base(
				IdentifierTerminal.S,
				new ParseAny(
					new ParseAll(DoubleColonTerminal.S, IdentifierTerminal.S),
					Empty.S),
				GenericDimensionSpecifier.O,
				UnboundTypeNameSuffixes.O)
		{
		}
	}
}
