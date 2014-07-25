using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    internal static class AttributeHelper
    {
        public static bool ReadAttribute(object target, XmlReader reader)
        {
            if (target is ICore)
            {
                if (ReadCore(target as ICore, reader))
                {
                    return true;
                }
            }
            if (target is IPresentation)
            {
                if (ReadPresentation(target as IPresentation, reader))
                {
                    return true;
                }
            }
            if (target is IConditionalProcessing)
            {
                if (ReadConditionalProcessing(target as IConditionalProcessing, reader))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ReadCore(ICore core, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "id":
                {
                    core.Id = reader.Value;
                    return true;
                }
                case "xml:base":
                {
                    core.XmlBase = reader.Value;
                    return true;
                }
                case "xml:lang":
                {
                    core.XmlLang = reader.Value;
                    return true;
                }
                case "xml:space":
                {
                    core.XmlSpace = reader.Value;
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }

        public static bool ReadConditionalProcessing(IConditionalProcessing conditionalProcessing, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "requiredFeatures":
                {
                    conditionalProcessing.RequiredFeatures = reader.Value;
                    return true;
                }
                case "requiredExtensions":
                {
                    conditionalProcessing.RequiredExtensions = reader.Value;
                    return true;
                }
                case "systemLanguage":
                {
                    conditionalProcessing.SystemLanguage = reader.Value;
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }

        public static bool ReadPresentation(IPresentation presentation, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "alignment-baseline":
                {
                    presentation.AlignmentBaseline = reader.Value;
                    return true;
                }
                case "baseline-shift":
                {
                    presentation.BaselineShift = reader.Value;
                    return true;
                }
                case "clip":
                {
                    presentation.Clip = reader.Value;
                    return true;
                }
                case "clip-path":
                {
                    presentation.ClipPath = reader.Value;
                    return true;
                }
                case "clip-rule":
                {
                    presentation.ClipRule = reader.Value;
                    return true;
                }
                case "color":
                {
                    presentation.Color = reader.Value;
                    return true;
                }
                case "color-interpolation":
                {
                    presentation.ColorInterpolation = reader.Value;
                    return true;
                }
                case "color-interpolation-filters":
                {
                    presentation.ColorInterpolationFilters = reader.Value;
                    return true;
                }
                case "color-profile":
                {
                    presentation.ColorProfile = reader.Value;
                    return true;
                }
                case "color-rendering":
                {
                    presentation.ColorRendering = reader.Value;
                    return true;
                }
                case "cursor":
                {
                    presentation.Cursor = reader.Value;
                    return true;
                }
                case "direction":
                {
                    presentation.Direction = reader.Value;
                    return true;
                }
                case "display":
                {
                    presentation.Display = reader.Value;
                    return true;
                }
                case "dominant-baseline":
                {
                    presentation.DominantBaseline = reader.Value;
                    return true;
                }
                case "enable-background":
                {
                    presentation.EnableBackground = reader.Value;
                    return true;
                }
                case "fill":
                {
                    presentation.Fill = reader.Value;
                    return true;
                }
                case "fill-opacity":
                {
                    presentation.FillOpacity = reader.Value;
                    return true;
                }
                case "fill-rule":
                {
                    presentation.FillRule = reader.Value;
                    return true;
                }
                case "filter":
                {
                    presentation.Filter = reader.Value;
                    return true;
                }
                case "flood-color":
                {
                    presentation.FloodColor = reader.Value;
                    return true;
                }
                case "flood-opacity":
                {
                    presentation.FloodOpacity = reader.Value;
                    return true;
                }
                case "font-family":
                {
                    presentation.FontFamily = reader.Value;
                    return true;
                }
                case "font-size":
                {
                    presentation.FontSize = reader.Value;
                    return true;
                }
                case "font-size-adjust":
                {
                    presentation.FontSizeAdjust = reader.Value;
                    return true;
                }
                case "font-stretch":
                {
                    presentation.FontStretch = reader.Value;
                    return true;
                }
                case "font-style":
                {
                    presentation.FontStyle = reader.Value;
                    return true;
                }
                case "font-variant":
                {
                    presentation.FontVariant = reader.Value;
                    return true;
                }
                case "font-weight":
                {
                    presentation.FontWeight = reader.Value;
                    return true;
                }
                case "glyph-orientation-horizontal":
                {
                    presentation.GlyphOrientationHorizontal = reader.Value;
                    return true;
                }
                case "glyph-orientation-vertical":
                {
                    presentation.GlyphOrientationVertical = reader.Value;
                    return true;
                }
                case "image-rendering":
                {
                    presentation.ImageRendering = reader.Value;
                    return true;
                }
                case "kerning":
                {
                    presentation.Kerning = reader.Value;
                    return true;
                }
                case "letter-spacing":
                {
                    presentation.LetterSpacing = reader.Value;
                    return true;
                }
                case "lighting-color":
                {
                    presentation.LightingColor = reader.Value;
                    return true;
                }
                case "marker-end":
                {
                    presentation.MarkerEnd = reader.Value;
                    return true;
                }
                case "marker-mid":
                {
                    presentation.MarkerMid = reader.Value;
                    return true;
                }
                case "marker-start":
                {
                    presentation.MarkerStart = reader.Value;
                    return true;
                }
                case "mask":
                {
                    presentation.Mask = reader.Value;
                    return true;
                }
                case "opacity":
                {
                    presentation.Opacity = reader.Value;
                    return true;
                }
                case "overflow":
                {
                    presentation.Overflow = reader.Value;
                    return true;
                }
                case "pointer-events":
                {
                    presentation.PointerEvents = reader.Value;
                    return true;
                }
                case "shape-rendering":
                {
                    presentation.ShapeRendering = reader.Value;
                    return true;
                }
                case "stop-color":
                {
                    presentation.StopColor = reader.Value;
                    return true;
                }
                case "stop-opacity":
                {
                    presentation.StopOpacity = reader.Value;
                    return true;
                }
                case "stroke":
                {
                    presentation.Stroke = reader.Value;
                    return true;
                }
                case "stroke-dasharray":
                {
                    presentation.StrokeDasharray = reader.Value;
                    return true;
                }
                case "stroke-dashoffset":
                {
                    presentation.StrokeDashoffset = reader.Value;
                    return true;
                }
                case "stroke-linecap":
                {
                    presentation.StrokeLinecap = reader.Value;
                    return true;
                }
                case "stroke-linejoin":
                {
                    presentation.StrokeLinejoin = reader.Value;
                    return true;
                }
                case "stroke-miterlimit":
                {
                    presentation.StrokeMiterlimit = reader.Value;
                    return true;
                }
                case "stroke-opacity":
                {
                    presentation.StrokeOpacity = reader.Value;
                    return true;
                }
                case "stroke-width":
                {
                    presentation.StrokeWidth = reader.Value;
                    return true;
                }
                case "text-anchor":
                {
                    presentation.TextAnchor = reader.Value;
                    return true;
                }
                case "text-decoration":
                {
                    presentation.TextDecoration = reader.Value;
                    return true;
                }
                case "text-rendering":
                {
                    presentation.TextRendering = reader.Value;
                    return true;
                }
                case "unicode-bidi":
                {
                    presentation.UnicodeBidi = reader.Value;
                    return true;
                }
                case "visibility":
                {
                    presentation.Visibility = reader.Value;
                    return true;
                }
                case "word-spacing":
                {
                    presentation.WordSpacing = reader.Value;
                    return true;
                }
                case "writing-mode":
                {
                    presentation.WritingMode = reader.Value;
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
}