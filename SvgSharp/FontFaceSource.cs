using System.Xml;

namespace SvgSharp
{
    public class FontFaceSource : BasicElement
    {
        public FontFaceUri Uri { get; set; }
        public FontFaceName Name { get; set; }

        protected override void ReadElement(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "font-face-name":
                {
                    Name = ElementHelper.Create<FontFaceName>(reader);
                    return;
                }
                case "font-face-uri":
                {
                    Uri = ElementHelper.Create<FontFaceUri>(reader);
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