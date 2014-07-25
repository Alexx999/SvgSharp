using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    public class Svg : Group
    {
        public const string Namespace = "http://www.w3.org/2000/svg";

        public string Version { get; set; }
        public string BaseProfile { get; set; }

        public static Svg FromFile(string path)
        {
            var file = File.OpenRead(path);

            return FromStream(file);
        }

        private static Svg FromStream(Stream stream)
        {

            Svg result = null;
            var settings = new XmlReaderSettings
            {
                ConformanceLevel = ConformanceLevel.Document,
                IgnoreComments = true,
                IgnoreWhitespace = true
            };
            using (var reader = XmlReader.Create(stream, settings))
            {
                if (reader.IsStartElement("svg"))
                {
                    result = new Svg();
                    result.FromXml(reader);
                }
            }

            return result;
        }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "version":
                {
                    Version = reader.Value;
                    return;
                }
                case "baseProfile":
                {
                    BaseProfile = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }
    }

    public class SvgElement : BasicElementWithDescription
    {
        public string Y { get; set; }
        public string X { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "width":
                {
                    Width = reader.Value;
                    return;
                }
                case "height":
                {
                    Height = reader.Value;
                    return;
                }
                case "x":
                {
                    X = reader.Value;
                    return;
                }
                case "y":
                {
                    Y = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }
    }

    public class Description : BasicElementWithDescription
    {
    }

    public class Metadata : BasicElementWithDescription
    {
    }
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

    public class Circle : SvgElement
    {
    }

    public class Group : SvgElement
    {
        public List<BasicElement> Elements { get; set; }

        public Group()
        {
            Elements = new List<BasicElement>();
        }

        protected override void ReadElement(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "rect":
                {
                    Elements.Add(ElementHelper.Create<Rect>(reader));
                    return;
                }
                case "circle":
                {
                    Elements.Add(ElementHelper.Create<Circle>(reader));
                    return;
                }
                case "path":
                {
                    Elements.Add(ElementHelper.Create<Path>(reader));
                    return;
                }
                case "defs":
                {
                    Elements.Add(ElementHelper.Create<Definition>(reader));
                    return;
                }
                case "g":
                {
                    Elements.Add(ElementHelper.Create<Group>(reader));
                    return;
                }
                case "svg":
                {
                    Elements.Add(ElementHelper.Create<Svg>(reader));
                    return;
                }
                case "font-face":
                {
                    Elements.Add(ElementHelper.Create<FontFace>(reader));
                    return;
                }
                case "text":
                {
                    Elements.Add(ElementHelper.Create<Text>(reader));
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

    public class Definition : Group
    {
    }

    public class Rect : SvgElement
    {
        public string Rx { get; set; }
        public string Ry { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "rx":
                {
                    Rx = reader.Value;
                    return;
                }
                case "ry":
                {
                    Ry = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }
    }

    public class Text : SvgElement
    {
        public string Dx { get; set; }
        public string Dy { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "dx":
                {
                    Dx = reader.Value;
                    return;
                }
                case "dy":
                {
                    Dy = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }
    }

    public class Title : BasicElementWithDescription
    {
        public string Data { get; set; }

        protected override void ReadContent(XmlReader reader)
        {
            Data = reader.ReadElementContentAsString();
        }
    }


    public class BasicElementWithDescription : BasicElement, ICore, IDescriptive
    {
        public Title Title { get; set; }
        public Metadata Metadata { get; set; }
        public Description Description { get; set; }


        protected override void ReadElement(XmlReader reader)
        {
            if(ElementHelper.ReadDescriptive(this, reader)) return;
            switch (reader.Name)
            {
                default:
                {
                    base.ReadElement(reader);
                    return;
                }
            }
        }
    }

    public class BasicElement : ICore
    {
        public string Id { get; set; }
        public string XmlBase { get; set; }
        public string XmlLang { get; set; }
        public string XmlSpace { get; set; }

        internal void FromXml(XmlReader reader)
        {
            var startDepth = reader.Depth;
            var childDepth = startDepth + 1;
            if (reader.HasAttributes)
            {
                while (reader.MoveToNextAttribute())
                {
                    ReadAttribute(reader);
                }
            }
            reader.MoveToElement();
            ReadContent(reader);
            while (reader.Depth > startDepth)
            {
                if (reader.Depth > childDepth)
                {
                    reader.Read();
                    continue;
                }
                if (reader.NodeType == XmlNodeType.Element)
                {
                    ReadElement(reader);
                }
                else
                {
                    reader.Read();
                }
            }
        }

        protected virtual void ReadContent(XmlReader reader)
        {
            reader.Read();
        }

        protected virtual void ReadElement(XmlReader reader)
        {
            reader.Read();
        }

        protected virtual void ReadAttribute(XmlReader reader)
        {
            AttributeHelper.ReadCore(this, reader);
        }
    }

    internal static class ElementHelper
    {
        public static T Create<T>(XmlReader reader) where T : BasicElement, new()
        {
            var result = new T();
            result.FromXml(reader);
            return result;
        }

        public static bool ReadDescriptive(IDescriptive descriptive, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "title":
                {
                    descriptive.Title = Create<Title>(reader);
                    return true;
                }
                case "desc":
                {
                    descriptive.Description = Create<Description>(reader);
                    return true;
                }
                case "metadata":
                {
                    descriptive.Metadata = Create<Metadata>(reader);
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
