using System.Collections.Generic;
using System.Xml;

namespace SvgSharp
{
    public class Group : GraphicsElement
    {
        public string Class { get; set; }
        public string Style { get; set; }
        public string ExternalResourcesRequired { get; set; }
        public string Transform { get; set; }
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

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "class":
                {
                    Class = reader.Value;
                    return;
                }
                case "style":
                {
                    Style = reader.Value;
                    return;
                }
                case "externalResourcesRequired":
                {
                    ExternalResourcesRequired = reader.Value;
                    return;
                }
                case "transform":
                {
                    Transform = reader.Value;
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
}