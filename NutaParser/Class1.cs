﻿// возможно убрать state.Deep ©®℗™
// in и out в типах
namespace NutaParser.Syntactic.Grammar
{
	public class TypeDeclaration : SyntacticItem
	{
		public static readonly TypeDeclaration S = new TypeDeclaration();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ClassDeclaration.S
				/*xxx*/);
		}
	}
}
