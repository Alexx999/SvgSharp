using System.Xml;

namespace SvgSharp
{
    public class Title : BasicElementWithDescription
    {
        public string Data { get; set; }

        protected override void ReadContent(XmlReader reader)
        {
            Data = reader.ReadElementContentAsString();
        }
    }
}