using System.Xml;

namespace SvgSharp
{
    public class Rect : GraphicsElement
    {
        public string Class { get; set; }
        public string Style { get; set; }
        public string ExternalResourcesRequired { get; set; }
        public string Transform { get; set; }
        public string Y { get; set; }
        public string X { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Rx { get; set; }
        public string Ry { get; set; }

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
                case "width":
                {
                    Width = reader.Value;
                    return;
                }
                case "height":
                {
                    Height = reader.Value;
                    return;
                }
                case "rx":
                {
                    Rx = reader.Value;
                    return;
                }
                case "ry":
                {
                    Ry = reader.Value;
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