﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Classes : GrammarTest
	{
		[TestMethod]
		public void Is_Class_Declaration()
		{
			//xxx
		}

		//xxx class-modifiers

		//xxx class-modifier

		//xxx type-parameter-list

		//xxx type-parameters

		//xxx type-parameter

		//xxx class-base

		//xxx interface-type-list

		//xxx type-parameter-constraints-clauses

		//xxx type-parameter-constraints-clause

		//xxx type-parameter-constraints

		//xxx primary-constraint

		//xxx secondary-constraints

		//xxx constructor-constraint

		//xxx class-body

		//xxx class-member-declarations

		//xxx class-member-declaration

		//xxx constant-declaration

		//xxx constant-modifiers

		//xxx constant-modifier

		//xxx constant-declarators

		//xxx constant-declarator

		//xxx field-declaration

		//xxx field-modifiers

		//xxx field-modifier

		//xxx variable-declarators

		//xxx variable-declarator

		//xxx variable-initializer

		//xxx method-declaration

		//xxx method-header

		//xxx method-modifiers

		//xxx method-modifier

		//xxx return-type

		[TestMethod]
		public void Is_Member_Name()
		{
			Check(true, MemberName.S, "Abc1");
			Check(true, MemberName.S, "IList.Abc");
			Check(true, MemberName.S, "System.Collections.IList.Abc");
			Check(false, MemberName.S, "1Abc");
			Check(false, MemberName.S, "Abc[]");
		}

		//xxx method-body

		//xxx formal-parameter-list

		//xxx fixed-parameters

		//xxx fixed-parameter

		//xxx default-argument

		//xxx parameter-modifier

		//xxx parameter-array

		[TestMethod]
		public void Is_Property_Declaration()
		{
			//xxx

			Check(true, PropertyDeclaration.S, "public IAttrGroup Data { get; private set; }");
			Check(true, PropertyDeclaration.S, "object IWrapper.Data { get { return Data; } }");
		}

		//xxx property-modifiers

		//xxx property-modifier

		//xxx accessor-declarations

		//xxx get-accessor-declaration

		//xxx set-accessor-declaration

		//xxx accessor-modifier

		//xxx accessor-body

		//xxx event-declaration

		//xxx event-modifiers

		//xxx event-modifier

		//xxx event-accessor-declarations

		//xxx add-accessor-declaration

		//xxx remove-accessor-declaration

		//xxx indexer-declaration

		//xxx indexer-modifiers

		//xxx indexer-modifier

		//xxx indexer-declarator

		//xxx operator-declaration

		//xxx operator-modifiers

		//xxx operator-modifier

		//xxx operator-declarator

		//xxx unary-operator-declarator

		//xxx overloadable-unary-operator

		//xxx binary-operator-declarator

		//xxx overloadable-binary-operator

		//xxx conversion-operator-declarator

		//xxx operator-body

		//xxx constructor-declaration

		//xxx constructor-modifiers

		//xxx constructor-modifier

		//xxx constructor-declarator

		//xxx constructor-initializer

		//xxx constructor-body

		//xxx static-constructor-declaration

		//xxx static-constructor-modifiers

		//xxx static-constructor-body

		[TestMethod]
		public void Is_Desctructor_Declaration()
		{
			//xxx

			Check(true, DestructorDeclaration.S, "~SqlExecutor() { Dispose(false); }");
		}

		//xxx destructor-body
	}
}
