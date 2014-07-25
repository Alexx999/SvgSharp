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

    public class Description : BasicElementWithDescription
    {
    }

    public class Metadata : BasicElementWithDescription
    {
    }

    public class Circle : GraphicsElement
    {
    }

    public class Group : GraphicsElement
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

    public class Text : GraphicsElement
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
}
