﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class IndexerModifier : ParseAny
	{
		public static readonly IndexerModifier S = new IndexerModifier();

		public IndexerModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				VirtualTerminal.S,
				SealedTerminal.S,
				OverrideTerminal.S,
				AbstractTerminal.S,
				ExternTerminal.S)
		{
		}
	}
}
