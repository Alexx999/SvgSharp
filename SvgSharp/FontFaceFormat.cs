using System.Xml;

namespace SvgSharp
{
    public class FontFaceFormat : BasicElement
    {
        public string Format { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "string":
                {
                    Format = reader.Value;
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