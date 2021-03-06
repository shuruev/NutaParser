﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ObjectCreationExpression : ParseAny
	{
		public static readonly ObjectCreationExpression S = new ObjectCreationExpression();

		public ObjectCreationExpression()
			: base(
				new ParseAll(
					NewTerminal.S,
					Type.S,
					LeftRoundBracketTerminal.S,
					ArgumentList.O,
					RightRoundBracketTerminal.S,
					ObjectOrCollectionInitializer.O),
				new ParseAll(
					NewTerminal.S,
					Type.S,
					ObjectOrCollectionInitializer.S))
		{
		}
	}
}
