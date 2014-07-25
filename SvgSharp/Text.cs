using System.Xml;

namespace SvgSharp
{
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
}