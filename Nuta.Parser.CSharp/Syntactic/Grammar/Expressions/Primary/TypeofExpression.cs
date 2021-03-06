﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeofExpression : ParseAny
	{
		public static readonly TypeofExpression S = new TypeofExpression();

		public TypeofExpression()
			: base(
				new ParseAll(
					TypeofTerminal.S,
					LeftRoundBracketTerminal.S,
					Type.S,
					RightRoundBracketTerminal.S),
				new ParseAll(
					TypeofTerminal.S,
					LeftRoundBracketTerminal.S,
					UnboundTypeName.S,
					RightRoundBracketTerminal.S),
				new ParseAll(
					TypeofTerminal.S,
					LeftRoundBracketTerminal.S,
					VoidTerminal.S,
					RightRoundBracketTerminal.S))
		{
		}
	}
}
