﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ArgumentValue : ParseAny
	{
		public static readonly ArgumentValue S = new ArgumentValue();

		public ArgumentValue()
			: base(
				Expression.S,
				new ParseAll(RefTerminal.S, VariableReference.S),
				new ParseAll(OutTerminal.S, VariableReference.S))
		{
		}
	}
}
