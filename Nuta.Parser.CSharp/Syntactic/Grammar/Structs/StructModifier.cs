﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StructModifier : ParseAny
	{
		public static readonly StructModifier S = new StructModifier();

		public StructModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S)
		{
		}
	}
}
