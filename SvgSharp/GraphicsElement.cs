using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    public class GraphicsElement : BasicElementWithDescription, IPresentation
    {
        public string AlignmentBaseline { get; set; }
        public string BaselineShift { get; set; }
        public string Clip { get; set; }
        public string ClipPath { get; set; }
        public string ClipRule { get; set; }
        public string Color { get; set; }
        public string ColorInterpolation { get; set; }
        public string ColorInterpolationFilters { get; set; }
        public string ColorProfile { get; set; }
        public string ColorRendering { get; set; }
        public string Cursor { get; set; }
        public string Direction { get; set; }
        public string Display { get; set; }
        public string DominantBaseline { get; set; }
        public string EnableBackground { get; set; }
        public string Fill { get; set; }
        public string FillOpacity { get; set; }
        public string FillRule { get; set; }
        public string Filter { get; set; }
        public string FloodColor { get; set; }
        public string FloodOpacity { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public string FontSizeAdjust { get; set; }
        public string FontStretch { get; set; }
        public string FontStyle { get; set; }
        public string FontVariant { get; set; }
        public string FontWeight { get; set; }
        public string GlyphOrientationHorizontal { get; set; }
        public string GlyphOrientationVertical { get; set; }
        public string ImageRendering { get; set; }
        public string Kerning { get; set; }
        public string LetterSpacing { get; set; }
        public string LightingColor { get; set; }
        public string MarkerEnd { get; set; }
        public string MarkerMid { get; set; }
        public string MarkerStart { get; set; }
        public string Mask { get; set; }
        public string Opacity { get; set; }
        public string Overflow { get; set; }
        public string PointerEvents { get; set; }
        public string ShapeRendering { get; set; }
        public string StopColor { get; set; }
        public string StopOpacity { get; set; }
        public string Stroke { get; set; }
        public string StrokeDasharray { get; set; }
        public string StrokeDashoffset { get; set; }
        public string StrokeLinecap { get; set; }
        public string StrokeLinejoin { get; set; }
        public string StrokeMiterlimit { get; set; }
        public string StrokeOpacity { get; set; }
        public string StrokeWidth { get; set; }
        public string TextAnchor { get; set; }
        public string TextDecoration { get; set; }
        public string TextRendering { get; set; }
        public string UnicodeBidi { get; set; }
        public string Visibility { get; set; }
        public string WordSpacing { get; set; }
        public string WritingMode { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            if (!AttributeHelper.ReadPresentation(this, reader))
            {
                base.ReadAttribute(reader);
            }
        }
    }
}