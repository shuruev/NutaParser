using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Letters : LexicalTest
	{
		[TestMethod]
		public void Is_Letter_Hex()
		{
			CheckLetter(LetterA.S, "a", false);
			CheckLetter(LetterB.S, "b", false);
			CheckLetter(LetterC.S, "c", false);
			CheckLetter(LetterD.S, "d", false);
			CheckLetter(LetterE.S, "e", false);
			CheckLetter(LetterF.S, "f", false);
		}

		[TestMethod]
		public void Is_Letter_Other()
		{
			CheckLetter(LetterG.S, "g", true);
			CheckLetter(LetterH.S, "h", true);
			CheckLetter(LetterI.S, "i", true);
			CheckLetter(LetterJ.S, "j", true);
			CheckLetter(LetterK.S, "k", true);
			CheckLetter(LetterL.S, "l", true);
			CheckLetter(LetterM.S, "m", true);
			CheckLetter(LetterN.S, "n", true);
			CheckLetter(LetterO.S, "o", true);
			CheckLetter(LetterP.S, "p", true);
			CheckLetter(LetterQ.S, "q", true);
			CheckLetter(LetterR.S, "r", true);
			CheckLetter(LetterS.S, "s", true);
			CheckLetter(LetterT.S, "t", true);
			CheckLetter(LetterU.S, "u", true);
			CheckLetter(LetterV.S, "v", true);
			CheckLetter(LetterW.S, "w", true);
			CheckLetter(LetterX.S, "x", true);
			CheckLetter(LetterY.S, "y", true);
			CheckLetter(LetterZ.S, "z", true);
		}

		/// <summary>
		/// Performs tests for letter lexem.
		/// </summary>
		private void CheckLetter(LexicalItem item, string letter, bool canEscape)
		{
			string lower = letter.ToLowerInvariant();
			string upper = letter.ToUpperInvariant();
			string lowerHex = ((int)lower[0]).ToString("x");
			string upperHex = ((int)upper[0]).ToString("x");
			string lowerHex1 = lowerHex.Substring(0, 1);
			string lowerHex2 = lowerHex.Substring(1, 1);
			string upperHex1 = upperHex.Substring(0, 1);
			string upperHex2 = upperHex.Substring(1, 1);

			string[] hexVariants = new[]
				{
					lowerHex1.ToLower() + lowerHex2.ToLower(),
					lowerHex1.ToLower() + lowerHex2.ToUpper(),
					lowerHex1.ToUpper() + lowerHex2.ToLower(),
					lowerHex1.ToUpper() + lowerHex2.ToUpper(),
					upperHex1.ToLower() + upperHex2.ToLower(),
					upperHex1.ToLower() + upperHex2.ToUpper(),
					upperHex1.ToUpper() + upperHex2.ToLower(),
					upperHex1.ToUpper() + upperHex2.ToUpper(),
				};

			Check(true, item, lower);
			Check(true, item, upper);
			Check(false, item, lower + " ");
			Check(false, item, " " + lower);

			Check(canEscape, item, "\\" + lower);
			Check(canEscape, item, "\\" + upper);
			Check(false, item, "\\\\" + lower);
			Check(false, item, lower + "\\");

			foreach (string hexVariant in hexVariants)
			{
				Check(true, item, "\\" + hexVariant);
				Check(true, item, "\\0" + hexVariant);
				Check(true, item, "\\00" + hexVariant);
				Check(true, item, "\\000" + hexVariant);
				Check(true, item, "\\0000" + hexVariant);
				Check(false, item, "\\00000" + hexVariant);
				Check(true, item, "\\" + hexVariant + " ");
				Check(false, item, "\\" + hexVariant + "  ");
				Check(true, item, "\\0" + hexVariant + "\r\n");
				Check(false, item, "\\0" + hexVariant + "\n\r");
				Check(true, item, "\\00" + hexVariant + "\r");
				Check(true, item, "\\00" + hexVariant + "\n");
				Check(true, item, "\\00" + hexVariant + "\t");
				Check(true, item, "\\00" + hexVariant + "\f");
			}
		}
	}
}
