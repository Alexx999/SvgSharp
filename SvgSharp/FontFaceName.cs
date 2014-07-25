using System.Xml;

namespace SvgSharp
{
    public class FontFaceName : BasicElement
    {
        public string Name { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "name":
                {
                    Name = reader.Value;
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