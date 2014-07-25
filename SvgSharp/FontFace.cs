using System.Xml;

namespace SvgSharp
{
    public class FontFace : BasicElementWithDescription
    {
        public string FontFamily { get; set; }
        public string FontStyle { get; set; }
        public string FontVariant { get; set; }
        public string FontWeight { get; set; }
        public string FontStretch { get; set; }
        public string FontSize { get; set; }
        public string UnicodeRange { get; set; }
        public string UnitsPerEm { get; set; }
        public string Panose1 { get; set; }
        public string Stemv { get; set; }
        public string Stemh { get; set; }
        public string Slope { get; set; }
        public string CapHeight { get; set; }
        public string XHeight { get; set; }
        public string AccentHeight { get; set; }
        public string Ascent { get; set; }
        public string Descent { get; set; }
        public string Widths { get; set; }
        public string BBox { get; set; }
        public string Ideographic { get; set; }
        public string Alphabetic { get; set; }
        public string Mathematical { get; set; }
        public string Hanging { get; set; }
        public string VIdeographic { get; set; }
        public string VAlphabetic { get; set; }
        public string VMathematical { get; set; }
        public string VHanging { get; set; }
        public string UnderlinePosition { get; set; }
        public string UnderlineThickness { get; set; }
        public string StrikethroughPosition { get; set; }
        public string StrikethroughThickness { get; set; }
        public string OverlinePosition { get; set; }
        public string OverlineThickness { get; set; }
        public FontFaceSource Source { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "font-family":
                {
                    FontFamily = reader.Value;
                    return;
                }
                case "font-style":
                {
                    FontStyle = reader.Value;
                    return;
                }
                case "font-variant":
                {
                    FontVariant = reader.Value;
                    return;
                }
                case "font-weight":
                {
                    FontWeight = reader.Value;
                    return;
                }
                case "font-stretch":
                {
                    FontStretch = reader.Value;
                    return;
                }
                case "font-size":
                {
                    FontSize = reader.Value;
                    return;
                }
                case "unicode-range":
                {
                    UnicodeRange = reader.Value;
                    return;
                }
                case "units-per-em":
                {
                    UnitsPerEm = reader.Value;
                    return;
                }
                case "panose-1":
                {
                    Panose1 = reader.Value;
                    return;
                }
                case "stemv":
                {
                    Stemv = reader.Value;
                    return;
                }
                case "stemh":
                {
                    Stemh = reader.Value;
                    return;
                }
                case "slope":
                {
                    Slope = reader.Value;
                    return;
                }
                case "cap-height":
                {
                    CapHeight = reader.Value;
                    return;
                }
                case "x-height":
                {
                    XHeight = reader.Value;
                    return;
                }
                case "accent-height":
                {
                    AccentHeight = reader.Value;
                    return;
                }
                case "ascent":
                {
                    Ascent = reader.Value;
                    return;
                }
                case "descent":
                {
                    Descent = reader.Value;
                    return;
                }
                case "widths":
                {
                    Widths = reader.Value;
                    return;
                }
                case "bbox":
                {
                    BBox = reader.Value;
                    return;
                }
                case "ideographic":
                {
                    Ideographic = reader.Value;
                    return;
                }
                case "alphabetic":
                {
                    Alphabetic = reader.Value;
                    return;
                }
                case "mathematical":
                {
                    Mathematical = reader.Value;
                    return;
                }
                case "hanging":
                {
                    Hanging = reader.Value;
                    return;
                }
                case "v-ideographic":
                {
                    VIdeographic = reader.Value;
                    return;
                }
                case "v-alphabetic":
                {
                    VAlphabetic = reader.Value;
                    return;
                }
                case "v-mathematical":
                {
                    VMathematical = reader.Value;
                    return;
                }
                case "v-hanging":
                {
                    VHanging = reader.Value;
                    return;
                }
                case "underline-position":
                {
                    UnderlinePosition = reader.Value;
                    return;
                }
                case "underline-thickness":
                {
                    UnderlineThickness = reader.Value;
                    return;
                }
                case "strikethrough-position":
                {
                    StrikethroughPosition = reader.Value;
                    return;
                }
                case "strikethrough-thickness":
                {
                    StrikethroughThickness = reader.Value;
                    return;
                }
                case "overline-position":
                {
                    OverlinePosition = reader.Value;
                    return;
                }
                case "overline-thickness":
                {
                    OverlineThickness = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }

        protected override void ReadElement(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "font-face-src":
                {
                    Source = ElementHelper.Create<FontFaceSource>(reader);
                    return;
                }
                default:
                {
                    base.ReadElement(reader);
                    return;
                }
            }
        }
    }
}