using System.Xml;

namespace SvgSharp
{
    public class FontFaceUri : BasicElement
    {
        public string Location { get; set; }
        public FontFaceFormat Format { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "xlink:href":
                {
                    Location = reader.Value;
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
                case "font-face-format":
                {
                    Format = ElementHelper.Create<FontFaceFormat>(reader);
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