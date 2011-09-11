﻿using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PropertyModifier : ParseAny
	{
		public static readonly PropertyModifier S = new PropertyModifier();

		public PropertyModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				StaticTerminal.S,
				VirtualTerminal.S,
				SealedTerminal.S,
				OverrideTerminal.S,
				AbstractTerminal.S,
				ExternTerminal.S)
		{
		}
	}
}
