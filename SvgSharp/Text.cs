using System.Xml;

namespace SvgSharp
{
    public class Text : GraphicsElement
    {
        public string Class { get; set; }
        public string Style { get; set; }
        public string ExternalResourcesRequired { get; set; }
        public string Transform { get; set; }
        public string LengthAdjust { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Dx { get; set; }
        public string Dy { get; set; }
        public string Rotate { get; set; }
        public string TextLength { get; set; }
        public string Value { get; set; }

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
                case "lengthAdjust":
                {
                    LengthAdjust = reader.Value;
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
                case "rotate":
                {
                    Rotate = reader.Value;
                    return;
                }
                case "textLength":
                {
                    TextLength = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }

        protected override void ReadContent(XmlReader reader)
        {
            Value = reader.ReadElementContentAsString();
        }
    }
}