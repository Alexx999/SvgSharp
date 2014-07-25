using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
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
}