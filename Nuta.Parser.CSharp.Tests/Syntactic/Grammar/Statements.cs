using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.CSharp.Syntactic;

namespace Nuta.Parser.CSharp.Tests.Syntactic
{
	[TestClass]
	public class Statements : SyntacticTest
	{
		[TestMethod]
		public void Is_Statement()
		{
			//xxx

			Check(true, Statement.S, "m_sqlCommand.Parameters.Add(\"RetVal\", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue;");
			Check(true, Statement.S, "string s = oldVal is DBNull ? \"(null)\" : oldVal.ToString();");
		}

		//xxx embedded-statement

		//xxx block

		//xxx statement-list

		//xxx empty-statement

		//xxx labeled-statement

		//xxx declaration-statement

		[TestMethod]
		public void Is_Declaration_Statement_Additional()
		{
			Check(true, DeclarationStatement.S, "var x;");
			Check(true, DeclarationStatement.S, "var y = { 1, 2, 3 };");
			Check(true, DeclarationStatement.S, "var z = null;");
			Check(true, DeclarationStatement.S, "var u = x => x + 1;");
			Check(true, DeclarationStatement.S, "var v = v++;");
			Check(true, DeclarationStatement.S, "int x = 1, y, z = x * 2;");

			Check(true, DeclarationStatement.S, "var i = 5;");
			Check(true, DeclarationStatement.S, "var s = \"Hello\";");
			Check(true, DeclarationStatement.S, "var d = 1.0;");
			Check(true, DeclarationStatement.S, "var numbers = new int[] { 1, 2, 3 };");
			Check(true, DeclarationStatement.S, "var orders = new Dictionary<int, Order>();");
			Check(true, DeclarationStatement.S, "int i = 5;");
			Check(true, DeclarationStatement.S, "string s = \"Hello\";");
			Check(true, DeclarationStatement.S, "double d = 1.0;");
			Check(true, DeclarationStatement.S, "int[] numbers = new int[] { 1, 2, 3 };");
			Check(true, DeclarationStatement.S, "Dictionary<int, Order> orders = new Dictionary<int, Order>();");
		}

		//xxx local-variable-declaration

		//xxx local-variable-type

		//xxx local-variable-declarators

		//xxx local-variable-declarator

		//xxx local-variable-initializer

		//xxx local-constant-declaration

		//xxx constant-declarators

		//xxx constant-declarator

		//xxx expression-statement

		//xxx statement-expression

		//xxx selection-statement

		[TestMethod]
		public void Is_Selection_Statement_Additional()
		{
			Check(true, SelectionStatement.S, "if (x) if (y) F(); else G();");
			Check(true, SelectionStatement.S, "if (x) { if (y) { F(); } else { G(); } }");

			Check(true, SelectionStatement.S, Syntactic.SwitchStatement1);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement2);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement3);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement4);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement5);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement6);
			Check(true, SelectionStatement.S, Syntactic.SwitchStatement7);
		}

		//xxx if-statement

		//xxx switch-statement

		//xxx switch-block

		//xxx switch-sections

		//xxx switch-section

		//xxx switch-labels

		//xxx switch-label

		[TestMethod]
		public void Is_Iteration_Statement()
		{
			Check(true, IterationStatement.S, "while (i < 5) i++;");
			Check(true, IterationStatement.S, "while (i < 5) { i++; Console.WriteLine(i); }");
			Check(true, IterationStatement.S, "do i++; while (i < 5);");
			Check(true, IterationStatement.S, "do { i++; Console.WriteLine(i); } while (i < 5);");
			Check(true, IterationStatement.S, "for (int i = 0; i < 5; i++) sum += i;");
			Check(true, IterationStatement.S, "for (int i = 0; i < 5; i++) { sum += i; Console.WriteLine(i); }");
			Check(true, IterationStatement.S, "for (;;) sum += i;");
			Check(true, IterationStatement.S, "for (;;) { sum += i; Console.WriteLine(i); }");
			Check(true, IterationStatement.S, "foreach (int i in numbers) sum += i;");
			Check(true, IterationStatement.S, "foreach (int i in numbers) { sum += i; Console.WriteLine(i); }");
		}

		//xxx while-statement

		//xxx do-statement

		//xxx for-statement

		//xxx for-initializer

		//xxx for-condition

		//xxx for-iterator

		//xxx statement-expression-list

		//xxx foreach-statement

		//xxx jump-statement

		//xxx break-statement

		//xxx continue-statement

		//xxx goto-statement

		//xxx return-statement

		//xxx throw-statement

		//xxx try-statement

		//xxx catch-clauses

		//xxx specific-catch-clauses

		//xxx specific-catch-clause

		//xxx general-catch-clause

		//xxx finally-clause

		//xxx checked-statement

		//xxx unchecked-statement

		//xxx lock-statement

		//xxx using-statement

		//xxx resource-acquisition

		//xxx yield-statement
	}
}
