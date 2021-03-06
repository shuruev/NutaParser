﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeParameterConstraints : ParseAny
	{
		public static readonly TypeParameterConstraints S = new TypeParameterConstraints();

		public TypeParameterConstraints()
			: base(
				new ParseAll(
					PrimaryConstraint.S,
					CommaTerminal.S,
					SecondaryConstraints.S,
					CommaTerminal.S,
					ConstructorConstraint.S),
				new ParseAll(
					PrimaryConstraint.S,
					CommaTerminal.S,
					SecondaryConstraints.S),
				new ParseAll(
					PrimaryConstraint.S,
					CommaTerminal.S,
					ConstructorConstraint.S),
				new ParseAll(
					SecondaryConstraints.S,
					CommaTerminal.S,
					ConstructorConstraint.S),
				PrimaryConstraint.S,
				SecondaryConstraints.S,
				ConstructorConstraint.S)
		{
		}
	}
}
