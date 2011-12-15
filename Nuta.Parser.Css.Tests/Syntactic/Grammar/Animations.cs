using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Animations : SyntacticTest
	{
		[TestMethod]
		public void Is_Keyframes_Rule()
		{
			Check(true, KeyframesRule.S, "@keyframes abc { }");
			Check(true, KeyframesRule.S, "@keyframes abc { from { } to { } }");
			Check(false, KeyframesRule.S, "@keyframes abc { { } }");

			Check(
				true,
				KeyframesRule.S,
				@"@keyframes bounce
					{
						from { top: 100px; animation-timing-function: ease-out; }
						50% { top: 100px; animation-timing-function: ease-out; }
						to { top: 100px; }
					}");
		}

		[TestMethod]
		public void Is_Keyframe_Block()
		{
			Check(true, KeyframeBlock.S, "from {}");
			Check(true, KeyframeBlock.S, "from { }");
			Check(true, KeyframeBlock.S, "from { }   ");
			Check(true, KeyframeBlock.S, "from { ;;; }");

			Check(true, KeyframeBlock.S, "from{color:red}");
			Check(true, KeyframeBlock.S, "from{color:red;}");

			Check(true, KeyframeBlock.S, "from { color: red }");
			Check(true, KeyframeBlock.S, "from { color: red; }");

			Check(true, KeyframeBlock.S, "from, 25% { width: 10px; height: 20px; }");
		}

		[TestMethod]
		public void Is_Keyframe_Selector_List()
		{
			Check(true, KeyframeSelectorList.S, "from,25%");
			Check(true, KeyframeSelectorList.S, "from, 25%");
			Check(true, KeyframeSelectorList.S, "from , 25%");
			Check(true, KeyframeSelectorList.S, "from , 25%   ");
			Check(true, KeyframeSelectorList.S, "   from , 25%");
			Check(true, KeyframeSelectorList.S, "   from , 25%   ");
			Check(false, KeyframeSelectorList.S, "from,, 25%");
		}

		[TestMethod]
		public void Is_Keyframe_Selector()
		{
			Check(true, KeyframeSelector.S, "from");
			Check(true, KeyframeSelector.S, "fRoM");
			Check(false, KeyframeSelector.S, "from ");

			Check(true, KeyframeSelector.S, "to");
			Check(true, KeyframeSelector.S, "tO");
			Check(false, KeyframeSelector.S, "to ");

			Check(true, KeyframeSelector.S, "25%");
			Check(true, KeyframeSelector.S, "0.25%");
			Check(true, KeyframeSelector.S, ".25%");
			Check(false, KeyframeSelector.S, "25 %");
			Check(false, KeyframeSelector.S, "25");
			Check(false, KeyframeSelector.S, "%");
		}
	}
}
