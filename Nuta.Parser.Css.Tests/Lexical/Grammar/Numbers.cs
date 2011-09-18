using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Numbers : LexicalTest
	{
		[TestMethod]
		public void Is_Number()
		{
			Check(true, Number.S, "0");
			Check(true, Number.S, "123");
			Check(true, Number.S, "123.4");
			Check(true, Number.S, "123.456");
			Check(true, Number.S, ".4");
			Check(true, Number.S, ".456");
			Check(false, Number.S, String.Empty);
			Check(false, Number.S, "-0");
			Check(false, Number.S, "-123");
			Check(false, Number.S, "123.");
			Check(false, Number.S, ".");
		}

		[TestMethod]
		public void Is_Percentage()
		{
			Check(true, Percentage.S, "123%");
			Check(true, Percentage.S, "123.45%");
			Check(true, Percentage.S, ".45%");
			Check(false, Percentage.S, "123.45 %");
			Check(false, Percentage.S, "12\\25");
		}

		[TestMethod]
		public void Is_Size()
		{
			Check(true, Size.S, "12eM");
			Check(true, Size.S, "12eX");
			Check(true, Size.S, "12e\\78");
		}

		[TestMethod]
		public void Is_Length()
		{
			Check(true, Length.S, "12pX");
			Check(true, Length.S, "12cM");
			Check(true, Length.S, "12mM");
			Check(true, Length.S, "12iN");
			Check(true, Length.S, "12pT");
			Check(true, Length.S, "12pC");
			Check(true, Length.S, "12p\\63");
		}

		[TestMethod]
		public void Is_Angle()
		{
			Check(true, Angle.S, "12dEg");
			Check(true, Angle.S, "12rAd");
			Check(true, Angle.S, "12gRad");
			Check(true, Angle.S, "12d\\65g");
		}

		[TestMethod]
		public void Is_Time()
		{
			Check(true, Time.S, "12mS");
			Check(true, Time.S, "12s");
			Check(true, Time.S, "12m\\73");
		}

		[TestMethod]
		public void Is_Freq()
		{
			Check(true, Freq.S, "12hZ");
			Check(true, Freq.S, "12kHz");
			Check(true, Freq.S, "12h\\7A");
		}

		[TestMethod]
		public void Is_Dimension()
		{
			Check(true, Dimension.S, "123Abc");
			Check(true, Dimension.S, "123.45Abc");
			Check(true, Dimension.S, ".45Abc");
			Check(true, Dimension.S, "123.45B\\&W\\?");
			Check(true, Dimension.S, "123.45B\\26W\\3F");
			Check(true, Dimension.S, "123.45B\\26 W\\3F ");
		}
	}
}
