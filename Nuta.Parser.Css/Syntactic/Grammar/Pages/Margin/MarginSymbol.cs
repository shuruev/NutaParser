using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MarginSymbol : ParseAny
	{
		public static readonly MarginSymbol S = new MarginSymbol();

		public MarginSymbol()
			: base(
				TopLeftCorner.S,
				TopLeft.S,
				TopCenter.S,
				TopRightCorner.S,
				TopRight.S,
				BottomLeftCorner.S,
				BottomLeft.S,
				BottomCenter.S,
				BottomRightCorner.S,
				BottomRight.S,
				LeftTop.S,
				LeftMiddle.S,
				LeftBottom.S,
				RightTop.S,
				RightMiddle.S,
				RightBottom.S)
		{
		}
	}
}
